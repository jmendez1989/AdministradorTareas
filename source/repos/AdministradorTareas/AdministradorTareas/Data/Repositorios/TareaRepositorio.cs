using AdministradorTareas.Data.Servicios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace AdministradorTareas.Data.Repositorios
{
    public class TareaRepositorio
    {
        private static readonly Lazy<TareaRepositorio> _instancia = new(() => new TareaRepositorio());

        private const string ConnectionString = "Data Source=Admtareas.db;Version=3;";

        public TareaRepositorio() 
        { 
        }

        public static TareaRepositorio Instancia => _instancia.Value;

        public List<Tarea> ListaTareas()
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    const string query = "SELECT * FROM Tareas ORDER BY FechaCompromiso";
                    return connection.Query<Tarea>(query).AsList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener la lista de tareas.", e);
            }
        }

        public void AgregarTarea(Tarea tarea)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    const string query = @"INSERT INTO Tareas 
                                           (Descripcion, Usuario, Estado, Prioridad, FechaCompromiso, Notas) 
                                           VALUES 
                                           (@Descripcion, @Usuario, @Estado, @Prioridad, @FechaCompromiso, @Notas)";
                    connection.Execute(query, tarea);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al agregar una tarea.", e);
            }
        }

        public void ActualizarTarea(Tarea tarea)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    const string query = @"UPDATE Tareas SET 
                                           Descripcion = @Descripcion, 
                                           Usuario = @Usuario, 
                                           Estado = @Estado, 
                                           Prioridad = @Prioridad, 
                                           FechaCompromiso = @FechaCompromiso, 
                                           Notas = @Notas
                                           WHERE Id = @Id";
                    connection.Execute(query, tarea);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar la tarea.", e);
            }
        }

        public void EliminarTarea(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    const string query = "DELETE FROM Tareas WHERE Id = @Id";
                    connection.Execute(query, new { Id = id });
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar la tarea.", e);
            }
        }
    }
}
