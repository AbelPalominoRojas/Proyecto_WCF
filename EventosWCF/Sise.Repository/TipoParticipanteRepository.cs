
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sise.Entities;
using System.Data;

namespace Sise.Repository
{
    public class TipoParticipanteRepository : AbstractCrud<TipoParticipante>
    {
        public override bool registrar(TipoParticipante tipoParticipante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_TipoParticipantes_Insert";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@codTipoParticipante", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.AddWithValue("@nombreTipoParticipante", tipoParticipante.NombreTipoParticipante);
                    sqlCommand.Parameters.AddWithValue("@estado", tipoParticipante.Estado);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool actualizar(TipoParticipante tipoParticipante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_TipoParticipantes_Update";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codTipoParticipante", tipoParticipante.CodTipoParticipante);
                    sqlCommand.Parameters.AddWithValue("@nombreTipoParticipante", tipoParticipante.NombreTipoParticipante);
                    sqlCommand.Parameters.AddWithValue("@estado", tipoParticipante.Estado);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool eliminar(TipoParticipante tipoParticipante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_TipoParticipantes_Delete";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codTipoParticipante", tipoParticipante.CodTipoParticipante);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override List<TipoParticipante> listar()
        {
            List<TipoParticipante> listTipoParticipantes = new List<TipoParticipante>();

            sqlQuery = "dbo.USP_TipoParticipantes_SelectAll";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        TipoParticipante resultTipoParticipantes = null;

                        while (sqlDataReader.Read())
                        {
                            resultTipoParticipantes = new TipoParticipante();
                            int codTipoParticipante_index = sqlDataReader.GetOrdinal("codTipoParticipante");
                            if (!sqlDataReader.IsDBNull(codTipoParticipante_index))
                                resultTipoParticipantes.CodTipoParticipante = sqlDataReader.GetInt32(codTipoParticipante_index);

                            int nombreTipoParticipante_index = sqlDataReader.GetOrdinal("nombreTipoParticipante");
                            if (!sqlDataReader.IsDBNull(nombreTipoParticipante_index))
                                resultTipoParticipantes.NombreTipoParticipante = sqlDataReader.GetString(nombreTipoParticipante_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultTipoParticipantes.Estado = sqlDataReader.GetString(estado_index);



                            listTipoParticipantes.Add(resultTipoParticipantes);
                        }
                    }
                }
            }

            return listTipoParticipantes;
        }

        public override TipoParticipante buscar(TipoParticipante tipoParticipante)
        {
            TipoParticipante resultTipoParticipantes = null;

            sqlQuery = "dbo.USP_TipoParticipantes_SelectById";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codTipoParticipante", tipoParticipante.CodTipoParticipante);

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        while (sqlDataReader.Read())
                        {
                            resultTipoParticipantes = new TipoParticipante();
                            int codTipoParticipante_index = sqlDataReader.GetOrdinal("codTipoParticipante");
                            if (!sqlDataReader.IsDBNull(codTipoParticipante_index))
                                resultTipoParticipantes.CodTipoParticipante = sqlDataReader.GetInt32(codTipoParticipante_index);

                            int nombreTipoParticipante_index = sqlDataReader.GetOrdinal("nombreTipoParticipante");
                            if (!sqlDataReader.IsDBNull(nombreTipoParticipante_index))
                                resultTipoParticipantes.NombreTipoParticipante = sqlDataReader.GetString(nombreTipoParticipante_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultTipoParticipantes.Estado = sqlDataReader.GetString(estado_index);



                        }
                    }
                }
            }

            return resultTipoParticipantes;
        }

    }
}
