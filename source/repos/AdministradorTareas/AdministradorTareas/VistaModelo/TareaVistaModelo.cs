using AdministradorTareas.Data;
using AdministradorTareas.Data.Repositorios;
using AdministradorTareas.Data.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AdministradorTareas.VistaModelo
{
    public class TareaVistaModelo : INotifyPropertyChanged
    {
        // Instancias necesarias para la lógica y repositorio de tareas
        public readonly TareaLogica _tareaLogica;
        public readonly TareaRepositorio _tareaRepositorio;

        // Colección observable que se utiliza para enlazar tareas a la interfaz gráfica
        public ObservableCollection<Tarea> Tareas { get; set; }

        // Constructor que inicializa las dependencias y la lista de tareas
        public TareaVistaModelo()
        {
            _tareaRepositorio = TareaRepositorio.Instancia;
            _tareaLogica = TareaLogica.Instancia;
            Tareas = new ObservableCollection<Tarea>(_tareaRepositorio.ListaTareas());
        }

        // Método para validar que una tarea cumpla con las reglas de negocio
        public bool ValidarTarea(Tarea tarea)
        {
            // Verifica que la descripción no esté vacía y no supere el límite
            if (string.IsNullOrWhiteSpace(tarea.Descripcion))
            {
                MessageBox.Show("La descripción de la tarea es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tarea.Descripcion.Length > 255)
            {
                MessageBox.Show("La descripción no puede exceder los 255 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica que el nombre del usuario sea válido
            if (string.IsNullOrWhiteSpace(tarea.Usuario))
            {
                MessageBox.Show("El nombre del usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tarea.Usuario.Length > 100)
            {
                MessageBox.Show("El nombre del usuario no puede exceder los 100 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica que el estado de la tarea sea uno de los permitidos
            var estadosValidos = new[] { "Pendiente", "En Proceso", "Completada" };
            if (!estadosValidos.Contains(tarea.Estado))
            {
                MessageBox.Show("El estado de la tarea es inválido. Debe ser 'Pendiente', 'En Proceso' o 'Completada'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica que la prioridad esté dentro de los valores aceptados
            var prioridadesValidas = new[] { "Baja", "Media", "Alta" };
            if (!prioridadesValidas.Contains(tarea.Prioridad))
            {
                MessageBox.Show("La prioridad de la tarea es inválida. Debe ser 'Baja', 'Media' o 'Alta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Valida las notas si están presentes
            if (!string.IsNullOrWhiteSpace(tarea.Notas) && tarea.Notas.Length > 500)
            {
                MessageBox.Show("Las notas no pueden exceder los 500 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica que no exista una tarea duplicada con la misma descripción y usuario
            var tareasExistentes = _tareaRepositorio.ListaTareas();
            if (tareasExistentes.Any(t => t.Descripcion == tarea.Descripcion && t.Usuario == tarea.Usuario && t.Id != tarea.Id))
            {
                MessageBox.Show("Ya existe una tarea con la misma descripción para este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // La fecha de compromiso debe ser igual o posterior al día actual
            if (tarea.FechaCompromiso < DateTime.Today)
            {
                MessageBox.Show("La fecha de compromiso no puede ser menor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }

        // Método para eliminar una tarea del repositorio y la colección observable
        public void EliminarTarea(int tareaId)
        {
            try
            {
                // Busca y elimina la tarea de la colección observable
                var tarea = Tareas.FirstOrDefault(t => t.Id == tareaId);
                if (tarea != null)
                {
                    Tareas.Remove(tarea);
                }

                // Elimina la tarea del repositorio
                _tareaRepositorio.EliminarTarea(tareaId);
            }
            catch (Exception e)
            {
                // Manejo de errores con un mensaje descriptivo
                throw new Exception("Error al eliminar la tarea en el ViewModel.", e);
            }
        }

        // Evento necesario para notificar cambios en las propiedades enlazadas a la UI
        public event PropertyChangedEventHandler PropertyChanged;

        // Método para invocar el evento PropertyChanged de forma segura
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
