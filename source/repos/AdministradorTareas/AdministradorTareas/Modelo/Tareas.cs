using System;
using System.ComponentModel;

namespace AdministradorTareas.Data
{
    public class Tarea : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        private string _descripcion;
        private string _usuario;
        private string _estado;
        private string _prioridad;
        private DateTime _fechaCompromiso;
        private string _notas;
        private DateTime _fechaCreacion;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Descripcion
        {
            get => _descripcion;
            set
            {
                _descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        public string Usuario
        {
            get => _usuario;
            set
            {
                _usuario = value;
                OnPropertyChanged(nameof(Usuario));
            }
        }

        public string Estado
        {
            get => _estado;
            set
            {
                _estado = value;
                OnPropertyChanged(nameof(Estado));
            }
        }

        public string Prioridad
        {
            get => _prioridad;
            set
            {
                _prioridad = value;
                OnPropertyChanged(nameof(Prioridad));
            }
        }

        public DateTime FechaCompromiso
        {
            get => _fechaCompromiso;
            set
            {
                _fechaCompromiso = value;
                OnPropertyChanged(nameof(FechaCompromiso));
            }
        }

        public string Notas
        {
            get => _notas;
            set
            {
                _notas = value;
                OnPropertyChanged(nameof(Notas));
            }
        }

        public DateTime FechaCreacion
        {
            get => _fechaCreacion;
            set
            {
                _fechaCreacion = value;
                OnPropertyChanged(nameof(FechaCreacion));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
