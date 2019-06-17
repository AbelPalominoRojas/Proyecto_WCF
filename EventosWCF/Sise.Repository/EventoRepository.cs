
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sise.Entities;
using System.Data;

namespace Sise.Repository
{
    public class EventoRepository : AbstractCrud<Evento>
    {
        public override bool registrar(Evento evento)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Eventos_Insert";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@codEvento", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.AddWithValue("@codAreaTematica", evento.CodAreaTematica);
                    sqlCommand.Parameters.AddWithValue("@nombreEvento", evento.NombreEvento);
                    sqlCommand.Parameters.AddWithValue("@descripcionEvento", evento.DescripcionEvento);
                    sqlCommand.Parameters.AddWithValue("@fechaEvento", evento.FechaEvento);
                    sqlCommand.Parameters.AddWithValue("@expositor", evento.Expositor);
                    sqlCommand.Parameters.AddWithValue("@lugarEvento", evento.LugarEvento);
                    sqlCommand.Parameters.AddWithValue("@limiteParticipantes", evento.LimiteParticipantes);
                    sqlCommand.Parameters.AddWithValue("@lugaresDisponibles", evento.LugaresDisponibles);
                    sqlCommand.Parameters.AddWithValue("@codUsuario", evento.CodUsuario);
                    sqlCommand.Parameters.AddWithValue("@estado", evento.Estado);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool actualizar(Evento evento)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Eventos_Update";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codEvento", evento.CodEvento);
                    sqlCommand.Parameters.AddWithValue("@codAreaTematica", evento.CodAreaTematica);
                    sqlCommand.Parameters.AddWithValue("@nombreEvento", evento.NombreEvento);
                    sqlCommand.Parameters.AddWithValue("@descripcionEvento", evento.DescripcionEvento);
                    sqlCommand.Parameters.AddWithValue("@fechaEvento", evento.FechaEvento);
                    sqlCommand.Parameters.AddWithValue("@expositor", evento.Expositor);
                    sqlCommand.Parameters.AddWithValue("@lugarEvento", evento.LugarEvento);
                    sqlCommand.Parameters.AddWithValue("@limiteParticipantes", evento.LimiteParticipantes);
                    sqlCommand.Parameters.AddWithValue("@lugaresDisponibles", evento.LugaresDisponibles);
                    sqlCommand.Parameters.AddWithValue("@codUsuario", evento.CodUsuario);
                    sqlCommand.Parameters.AddWithValue("@estado", evento.Estado);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool eliminar(Evento evento)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Eventos_Delete";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codEvento", evento.CodEvento);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override List<Evento> listar()
        {
            List<Evento> listEventos = new List<Evento>();

            sqlQuery = "dbo.USP_Eventos_SelectAll";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        Evento resultEventos = null;

                        while (sqlDataReader.Read())
                        {
                            resultEventos = new Evento();
                            int codEvento_index = sqlDataReader.GetOrdinal("codEvento");
                            if (!sqlDataReader.IsDBNull(codEvento_index))
                                resultEventos.CodEvento = sqlDataReader.GetInt32(codEvento_index);

                            int codAreaTematica_index = sqlDataReader.GetOrdinal("codAreaTematica");
                            if (!sqlDataReader.IsDBNull(codAreaTematica_index))
                                resultEventos.CodAreaTematica = sqlDataReader.GetInt32(codAreaTematica_index);

                            int nombreEvento_index = sqlDataReader.GetOrdinal("nombreEvento");
                            if (!sqlDataReader.IsDBNull(nombreEvento_index))
                                resultEventos.NombreEvento = sqlDataReader.GetString(nombreEvento_index);

                            int descripcionEvento_index = sqlDataReader.GetOrdinal("descripcionEvento");
                            if (!sqlDataReader.IsDBNull(descripcionEvento_index))
                                resultEventos.DescripcionEvento = sqlDataReader.GetString(descripcionEvento_index);

                            int fechaEvento_index = sqlDataReader.GetOrdinal("fechaEvento");
                            if (!sqlDataReader.IsDBNull(fechaEvento_index))
                                resultEventos.FechaEvento = sqlDataReader.GetDateTime(fechaEvento_index);

                            int expositor_index = sqlDataReader.GetOrdinal("expositor");
                            if (!sqlDataReader.IsDBNull(expositor_index))
                                resultEventos.Expositor = sqlDataReader.GetString(expositor_index);

                            int lugarEvento_index = sqlDataReader.GetOrdinal("lugarEvento");
                            if (!sqlDataReader.IsDBNull(lugarEvento_index))
                                resultEventos.LugarEvento = sqlDataReader.GetString(lugarEvento_index);

                            int limiteParticipantes_index = sqlDataReader.GetOrdinal("limiteParticipantes");
                            if (!sqlDataReader.IsDBNull(limiteParticipantes_index))
                                resultEventos.LimiteParticipantes = sqlDataReader.GetInt32(limiteParticipantes_index);

                            int lugaresDisponibles_index = sqlDataReader.GetOrdinal("lugaresDisponibles");
                            if (!sqlDataReader.IsDBNull(lugaresDisponibles_index))
                                resultEventos.LugaresDisponibles = sqlDataReader.GetInt32(lugaresDisponibles_index);

                            int codUsuario_index = sqlDataReader.GetOrdinal("codUsuario");
                            if (!sqlDataReader.IsDBNull(codUsuario_index))
                                resultEventos.CodUsuario = sqlDataReader.GetInt32(codUsuario_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultEventos.Estado = sqlDataReader.GetString(estado_index);



                            listEventos.Add(resultEventos);
                        }
                    }
                }
            }

            return listEventos;
        }

        public override Evento buscar(Evento evento)
        {
            Evento resultEventos = null;

            sqlQuery = "dbo.USP_Eventos_SelectById";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codEvento", evento.CodEvento);

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        while (sqlDataReader.Read())
                        {
                            resultEventos = new Evento();
                            int codEvento_index = sqlDataReader.GetOrdinal("codEvento");
                            if (!sqlDataReader.IsDBNull(codEvento_index))
                                resultEventos.CodEvento = sqlDataReader.GetInt32(codEvento_index);

                            int codAreaTematica_index = sqlDataReader.GetOrdinal("codAreaTematica");
                            if (!sqlDataReader.IsDBNull(codAreaTematica_index))
                                resultEventos.CodAreaTematica = sqlDataReader.GetInt32(codAreaTematica_index);

                            int nombreEvento_index = sqlDataReader.GetOrdinal("nombreEvento");
                            if (!sqlDataReader.IsDBNull(nombreEvento_index))
                                resultEventos.NombreEvento = sqlDataReader.GetString(nombreEvento_index);

                            int descripcionEvento_index = sqlDataReader.GetOrdinal("descripcionEvento");
                            if (!sqlDataReader.IsDBNull(descripcionEvento_index))
                                resultEventos.DescripcionEvento = sqlDataReader.GetString(descripcionEvento_index);

                            int fechaEvento_index = sqlDataReader.GetOrdinal("fechaEvento");
                            if (!sqlDataReader.IsDBNull(fechaEvento_index))
                                resultEventos.FechaEvento = sqlDataReader.GetDateTime(fechaEvento_index);

                            int expositor_index = sqlDataReader.GetOrdinal("expositor");
                            if (!sqlDataReader.IsDBNull(expositor_index))
                                resultEventos.Expositor = sqlDataReader.GetString(expositor_index);

                            int lugarEvento_index = sqlDataReader.GetOrdinal("lugarEvento");
                            if (!sqlDataReader.IsDBNull(lugarEvento_index))
                                resultEventos.LugarEvento = sqlDataReader.GetString(lugarEvento_index);

                            int limiteParticipantes_index = sqlDataReader.GetOrdinal("limiteParticipantes");
                            if (!sqlDataReader.IsDBNull(limiteParticipantes_index))
                                resultEventos.LimiteParticipantes = sqlDataReader.GetInt32(limiteParticipantes_index);

                            int lugaresDisponibles_index = sqlDataReader.GetOrdinal("lugaresDisponibles");
                            if (!sqlDataReader.IsDBNull(lugaresDisponibles_index))
                                resultEventos.LugaresDisponibles = sqlDataReader.GetInt32(lugaresDisponibles_index);

                            int codUsuario_index = sqlDataReader.GetOrdinal("codUsuario");
                            if (!sqlDataReader.IsDBNull(codUsuario_index))
                                resultEventos.CodUsuario = sqlDataReader.GetInt32(codUsuario_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultEventos.Estado = sqlDataReader.GetString(estado_index);



                        }
                    }
                }
            }

            return resultEventos;
        }

    }
}
