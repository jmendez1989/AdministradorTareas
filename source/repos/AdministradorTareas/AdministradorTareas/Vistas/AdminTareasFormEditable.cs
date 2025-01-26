using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministradorTareas.Data;
using AdministradorTareas.VistaModelo;

namespace AdministradorTareas
{
    public partial class AdminTareasFormEditable : Form
    {
        #region Campos

        private readonly TareaVistaModelo _tareaVistaModelo;
        private readonly Tarea _taskRepository;
        private Tarea _currentTask;

        #endregion

        #region Constructores

        public AdminTareasFormEditable()
        {
            InitializeComponent();
            _tareaVistaModelo = new TareaVistaModelo();
            _currentTask = new Tarea(); // Nueva tarea
            LoadDropdowns();
            ConfigureBindings();
        }

        public AdminTareasFormEditable(Tarea Tarea)
        {
            InitializeComponent();
            _tareaVistaModelo = new TareaVistaModelo();
            _currentTask = Tarea;
            LoadDropdowns();
            ConfigureBindings();
        }

        #endregion

        #region Métodos de Inicialización

        private void LoadDropdowns()
        {
            cmbEstado.Items.AddRange(new[] { "Pendiente", "En Proceso", "Completada" });
            cmbPrioridad.Items.AddRange(new[] { "Baja", "Media", "Alta" });
        }

        private void ConfigureBindings()
        {
            try
            {
                // Vincula la propiedad "Value" solo si el valor es válido
                if (_currentTask.FechaCompromiso >= dtpFechaCompromiso.MinDate && _currentTask.FechaCompromiso <= dtpFechaCompromiso.MaxDate)
                {
                    dtpFechaCompromiso.DataBindings.Add("Value", _currentTask, "FechaCompromiso");
                }
                else
                {
                    _currentTask.FechaCompromiso = DateTime.Now; // Ajustar a una fecha válida
                    dtpFechaCompromiso.DataBindings.Add("Value", _currentTask, "FechaCompromiso");
                }

                // Otros bindings
                txtDescription.DataBindings.Add("Text", _currentTask, "Descripcion");
                txtUsuario.DataBindings.Add("Text", _currentTask, "Usuario");
                txtNotas.DataBindings.Add("Text", _currentTask, "Notas");
                cmbEstado.DataBindings.Add("SelectedItem", _currentTask, "Estado");
                cmbPrioridad.DataBindings.Add("SelectedItem", _currentTask, "Prioridad");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar bindings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos de Botones

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar datos
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("La descripción es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!_tareaVistaModelo.ValidarTarea(_currentTask))
                {
                    MessageBox.Show("Los datos de la tarea son inválidos.", "Administrador de Tareas");
                    return;
                }

                // Guardar en la base de datos
                if (_currentTask.Id == 0)
                {
                    _tareaVistaModelo._tareaRepositorio.AgregarTarea(_currentTask); // Agregar nueva tarea
                    MessageBox.Show("Tarea creada con éxito.", "Administrador de Tareas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _tareaVistaModelo._tareaRepositorio.ActualizarTarea(_currentTask); // Actualizar tarea existente
                    MessageBox.Show("Tarea actualizada con éxito.", "Administrador de Tareas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas cancelar? Los cambios no se guardarán.",
                                              "Confirmar cancelación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        #endregion

        #region Placeholders de Texto

        private void HandlePlaceholder(TextBox textBox, string placeholderText, bool isEntering)
        {
            if (isEntering && textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
            else if (!isEntering && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e) => HandlePlaceholder(txtDescription, "Escribe aquí la descripción de la tarea...", true);

        private void txtDescription_Leave(object sender, EventArgs e) => HandlePlaceholder(txtDescription, "Escribe aquí la descripción de la tarea...", false);

        private void txtUsuario_Enter(object sender, EventArgs e) => HandlePlaceholder(txtUsuario, "Escribe aquí el nombre del Usuario de la tarea...", true);

        private void txtUsuario_Leave(object sender, EventArgs e) => HandlePlaceholder(txtUsuario, "Escribe aquí el nombre del Usuario de la tarea...", false);

        #endregion
    }
}
