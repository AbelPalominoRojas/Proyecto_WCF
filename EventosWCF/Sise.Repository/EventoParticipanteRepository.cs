
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sise.Entities;
using System.Data;

namespace Sise.Repository
{
    public class EventoParticipanteRepository : AbstractCrud<EventoParticipante>
    {
        public override bool create(EventoParticipante eventoParticipante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_EventoParticipantes_Insert";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codEvento", eventoParticipante.CodEvento);
                    sqlCommand.Parameters.AddWithValue("@codParticipante", eventoParticipante.CodParticipante);
                    sqlCommand.Parameters.AddWithValue("@fechaRegistro", eventoParticipante.FechaRegistro);
                    sqlCommand.Parameters.AddWithValue("@participanteAsistio", eventoParticipante.ParticipanteAsistio);
                    sqlCommand.Parameters.AddWithValue("@codUsuario", eventoParticipante.CodUsuario);
                    sqlCommand.Parameters.AddWithValue("@estado", eventoParticipante.Estado);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool edit(EventoParticipante eventoParticipante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_EventoParticipantes_Update";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codEvento", eventoParticipante.CodEvento);
                    sqlCommand.Parameters.AddWithValue("@codParticipante", eventoParticipante.CodParticipante);
                    sqlCommand.Parameters.AddWithValue("@fechaRegistro", eventoParticipante.FechaRegistro);
                    sqlCommand.Parameters.AddWithValue("@participanteAsistio", eventoParticipante.ParticipanteAsistio);
                    sqlCommand.Parameters.AddWithValue("@codUsuario", eventoParticipante.CodUsuario);
                    sqlCommand.Parameters.AddWithValue("@estado", eventoParticipante.Estado);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool remove(EventoParticipante eventoParticipante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_EventoParticipantes_Delete";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codEvento", eventoParticipante.CodEvento);
                    sqlCommand.Parameters.AddWithValue("@codParticipante", eventoParticipante.CodParticipante);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override List<EventoParticipante> findAll()
        {
            List<EventoParticipante> listEventoParticipantes = new List<EventoParticipante>();

            sqlQuery = "dbo.USP_EventoParticipantes_SelectAll";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        EventoParticipante resultEventoParticipantes = null;

                        while (sqlDataReader.Read())
                        {
                            resultEventoParticipantes = new EventoParticipante();
                            int codEvento_index = sqlDataReader.GetOrdinal("codEvento");
                            if (!sqlDataReader.IsDBNull(codEvento_index))
                                resultEventoParticipantes.CodEvento = sqlDataReader.GetInt32(codEvento_index);

                            int codParticipante_index = sqlDataReader.GetOrdinal("codParticipante");
                            if (!sqlDataReader.IsDBNull(codParticipante_index))
                                resultEventoParticipantes.CodParticipante = sqlDataReader.GetInt32(codParticipante_index);

                            int fechaRegistro_index = sqlDataReader.GetOrdinal("fechaRegistro");
                            if (!sqlDataReader.IsDBNull(fechaRegistro_index))
                                resultEventoParticipantes.FechaRegistro = sqlDataReader.GetDateTime(fechaRegistro_index);

                            int participanteAsistio_index = sqlDataReader.GetOrdinal("participanteAsistio");
                            if (!sqlDataReader.IsDBNull(participanteAsistio_index))
                                resultEventoParticipantes.ParticipanteAsistio = sqlDataReader.GetBoolean(participanteAsistio_index);

                            int codUsuario_index = sqlDataReader.GetOrdinal("codUsuario");
                            if (!sqlDataReader.IsDBNull(codUsuario_index))
                                resultEventoParticipantes.CodUsuario = sqlDataReader.GetInt32(codUsuario_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultEventoParticipantes.Estado = sqlDataReader.GetString(estado_index);



                            listEventoParticipantes.Add(resultEventoParticipantes);
                        }
                    }
                }
            }

            return listEventoParticipantes;
        }

        public override EventoParticipante find(EventoParticipante eventoParticipante)
        {
            EventoParticipante resultEventoParticipantes = null;

            sqlQuery = "dbo.USP_EventoParticipantes_SelectById";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codEvento", eventoParticipante.CodEvento);
                    sqlCommand.Parameters.AddWithValue("@codParticipante", eventoParticipante.CodParticipante);

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        while (sqlDataReader.Read())
                        {
                            resultEventoParticipantes = new EventoParticipante();
                            int codEvento_index = sqlDataReader.GetOrdinal("codEvento");
                            if (!sqlDataReader.IsDBNull(codEvento_index))
                                resultEventoParticipantes.CodEvento = sqlDataReader.GetInt32(codEvento_index);

                            int codParticipante_index = sqlDataReader.GetOrdinal("codParticipante");
                            if (!sqlDataReader.IsDBNull(codParticipante_index))
                                resultEventoParticipantes.CodParticipante = sqlDataReader.GetInt32(codParticipante_index);

                            int fechaRegistro_index = sqlDataReader.GetOrdinal("fechaRegistro");
                            if (!sqlDataReader.IsDBNull(fechaRegistro_index))
                                resultEventoParticipantes.FechaRegistro = sqlDataReader.GetDateTime(fechaRegistro_index);

                            int participanteAsistio_index = sqlDataReader.GetOrdinal("participanteAsistio");
                            if (!sqlDataReader.IsDBNull(participanteAsistio_index))
                                resultEventoParticipantes.ParticipanteAsistio = sqlDataReader.GetBoolean(participanteAsistio_index);

                            int codUsuario_index = sqlDataReader.GetOrdinal("codUsuario");
                            if (!sqlDataReader.IsDBNull(codUsuario_index))
                                resultEventoParticipantes.CodUsuario = sqlDataReader.GetInt32(codUsuario_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultEventoParticipantes.Estado = sqlDataReader.GetString(estado_index);



                        }
                    }
                }
            }

            return resultEventoParticipantes;
        }
    }
}