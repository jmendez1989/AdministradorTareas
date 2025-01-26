using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdministradorTareas.Data.Servicios
{
    public class TareaLogica
    {
        private static readonly Lazy<TareaLogica> _instancia = new(() => new TareaLogica());

        private const string ConnectionString = "Data Source=Admtareas.db;Version=3;";

        public TareaLogica() 
        { 
        }

        public static TareaLogica Instancia => _instancia.Value;

        public IEnumerable<Tarea> ObtenerListaFiltradaTareas(DateTime? FechaInicio, DateTime? FechaFin, string Usuario, string Estado, string Prioridad)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    var query = "SELECT * FROM Tareas WHERE 1=1";
                    var parameters = new DynamicParameters();

                    if (FechaInicio.HasValue)
                    {
                        query += " AND FechaCompromiso >= @FechaInicio";
                        parameters.Add("@FechaInicio", FechaInicio.Value.Date);
                    }

                    if (FechaFin.HasValue)
                    {
                        query += " AND FechaCompromiso <= @FechaFin";
                        parameters.Add("@FechaFin", FechaFin.Value.Date.AddDays(1).AddSeconds(-1));
                    }

                    if (!string.IsNullOrEmpty(Usuario))
                    {
                        query += " AND Usuario = @Usuario";
                        parameters.Add("@Usuario", Usuario);
                    }

                    if (!string.IsNullOrEmpty(Estado))
                    {
                        query += " AND Estado = @Estado";
                        parameters.Add("@Estado", Estado);
                    }

                    if (!string.IsNullOrEmpty(Prioridad))
                    {
                        query += " AND Prioridad = @Prioridad";
                        parameters.Add("@Prioridad", Prioridad);
                    }

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
