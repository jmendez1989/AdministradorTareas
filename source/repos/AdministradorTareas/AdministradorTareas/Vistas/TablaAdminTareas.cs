using AdministradorTareas.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using AdministradorTareas.VistaModelo;

namespace AdministradorTareas
{
    public partial class TablaAdminTareas : Form
    {
        #region Campos
        private List<Tarea> tareas;
        private readonly TareaVistaModelo _tareaVistaModelo;
        #endregion

        #region Constructor
        public TablaAdminTareas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            _tareaVistaModelo = new TareaVistaModelo();
            MostrarTareas();
            LoadDropdowns();
        }
        #endregion

        #region Inicializacion
        private void LoadDropdowns()
        {
            cmbFiltroEstado.Items.AddRange(new[] { "Pendiente", "En Proceso", "Completada" });
            cmbFiltroPrioridad.Items.AddRange(new[] { "Baja", "Media", "Alta" });
        }

        private void MostrarTareas()
        {
            var tareasOrdenadas = _tareaVistaModelo._tareaRepositorio.ListaTareas().OrderBy(t => t.FechaCompromiso).ToList();

            dataGridViewTareas.DataSource = null;
            dataGridViewTareas.DataSource = tareasOrdenadas;

            dataGridViewTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }
        #endregion

        #region Eventos de Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new AdminTareasFormEditable())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MostrarTareas();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una tarea para editar.", "Administrador de Tareas");
                return;
            }

            var selectedTask = (Tarea)dataGridViewTareas.SelectedRows[0].DataBoundItem;

            if (selectedTask.Estado == "Completada")
            {
                MessageBox.Show("No se pueden editar tareas en estado Completado.", "Administrador de Tareas");
                return;
            }

            using (var form = new AdminTareasFormEditable(selectedTask))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MostrarTareas();
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.","Administrador de Tareas");
                return;
            }

            var selectedTask = (Tarea)dataGridViewTareas.SelectedRows[0].DataBoundItem;

            if (selectedTask.Estado == "En Proceso")
            {
                MessageBox.Show("No se pueden eliminar tareas en estado En Proceso.", "Administrador de Tareas");
                return;
            }

            var confirmResult = MessageBox.Show("¿Estás seguro que deseas eliminar esta tarea?",
                "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _tareaVistaModelo.EliminarTarea(selectedTask.Id);
                    MostrarTareas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al borrar registros: {ex.Message}", "Administrador de Tareas");
                }
            }
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = txtFiltroUsuario.Text != "Usuario" ? txtFiltroUsuario.Text : null;
                var estado = cmbFiltroEstado.Text != "Estado" ? cmbFiltroEstado.Text : null;
                var prioridad = cmbFiltroPrioridad.Text != "Prioridad" ? cmbFiltroPrioridad.Text : null;
                var fechaInicio = dtpFechaDesde.Value;
                var fechaFin = dtpFechaHasta.Value;

                var tareasFiltradas = _tareaVistaModelo._tareaLogica.ObtenerListaFiltradaTareas(fechaInicio, fechaFin, usuario, estado, prioridad);

                dataGridViewTareas.DataSource = tareasFiltradas.OrderBy(t => t.FechaCompromiso).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al aplicar filtros: {ex.Message}", "Administrador de Tareas");
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                txtFiltroUsuario.Text = "Usuario";
                cmbFiltroEstado.Text = "Estado";
                cmbFiltroPrioridad.Text = "Prioridad";
                dtpFechaDesde.Value = new DateTime(1980, 1, 1);
                dtpFechaHasta.Value = DateTime.Now;

                MostrarTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al Limpiar los filtros: {ex.Message}", "Administrador de Tareas");
            }
        }
        #endregion
    }
}
