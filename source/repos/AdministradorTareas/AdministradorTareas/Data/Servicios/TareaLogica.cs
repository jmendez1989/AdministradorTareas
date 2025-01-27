using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdministradorTareas.Data.Servicios
{
    public class TareaLogica
    {
        // Implementación del patrón Singleton para garantizar una única instancia de la clase
        private static readonly Lazy<TareaLogica> _instancia = new(() => new TareaLogica());
        private const string ConnectionString = "Data Source=Admtareas.db;Version=3;";

        // Constructor privado para prevenir la instanciación externa
        public TareaLogica() 
        { 
        }

        // Propiedad para acceder a la única instancia de la clase
        public static TareaLogica Instancia => _instancia.Value;

        // Método para obtener una lista de tareas filtradas según los criterios proporcionados
        public IEnumerable<Tarea> ObtenerListaFiltradaTareas(DateTime? FechaInicio, DateTime? FechaFin, string Usuario, string Estado, string Prioridad)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    // Construcción dinámica de la consulta SQL según los parámetros proporcionados
                    var query = "SELECT * FROM Tareas WHERE 1=1";
                    var parameters = new DynamicParameters();

                    // Filtro por fecha de inicio, si se especifica
                    if (FechaInicio.HasValue)
                    {
                        query += " AND FechaCompromiso >= @FechaInicio";
                        parameters.Add("@FechaInicio", FechaInicio.Value.Date);
                    }

                    // Filtro por fecha de fin, si se especifica
                    if (FechaFin.HasValue)
                    {
                        query += " AND FechaCompromiso <= @FechaFin";
                        parameters.Add("@FechaFin", FechaFin.Value.Date.AddDays(1).AddSeconds(-1));
                    }

                    // Filtro por usuario, si se especifica
                    if (!string.IsNullOrEmpty(Usuario))
                    {
                        query += " AND Usuario = @Usuario";
                        parameters.Add("@Usuario", Usuario);
                    }

                    // Filtro por estado, si se especifica
                    if (!string.IsNullOrEmpty(Estado))
                    {
                        query += " AND Estado = @Estado";
                        parameters.Add("@Estado", Estado);
                    }

                    // Filtro por prioridad, si se especifica
                    if (!string.IsNullOrEmpty(Prioridad))
                    {
                        query += " AND Prioridad = @Prioridad";
                        parameters.Add("@Prioridad", Prioridad);
                    }

                    // Ejecución de la consulta y retorno de los resultados
                    return connection.Query<Tarea>(query, parameters);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener la lista filtrada de tareas.", e);
            }
        }
    }
}
