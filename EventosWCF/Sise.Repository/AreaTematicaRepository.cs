
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sise.Entities;
using System.Data;

namespace Sise.Repository
{
    public class AreaTematicaRepository : AbstractCrud<AreaTematica>
    {
        public override bool create(AreaTematica areaTematica)
        {
            bool result = false;

            sqlQuery = "dbo.USP_AreaTematicas_Insert";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@codAreaTematica", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.AddWithValue("@nombreAreaTematica", areaTematica.NombreAreaTematica);
                    sqlCommand.Parameters.AddWithValue("@estado", areaTematica.Estado);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool edit(AreaTematica areaTematica)
        {
            bool result = false;

            sqlQuery = "dbo.USP_AreaTematicas_Update";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codAreaTematica", areaTematica.CodAreaTematica);
                    sqlCommand.Parameters.AddWithValue("@nombreAreaTematica", areaTematica.NombreAreaTematica);
                    sqlCommand.Parameters.AddWithValue("@estado", areaTematica.Estado);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool remove(AreaTematica areaTematica)
        {
            bool result = false;

            sqlQuery = "dbo.USP_AreaTematicas_Delete";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codAreaTematica", areaTematica.CodAreaTematica);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override List<AreaTematica> findAll()
        {
            List<AreaTematica> listAreaTematicas = new List<AreaTematica>();

            sqlQuery = "dbo.USP_AreaTematicas_SelectAll";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        AreaTematica resultAreaTematicas = null;

                        while (sqlDataReader.Read())
                        {
                            resultAreaTematicas = new AreaTematica();
                            int codAreaTematica_index = sqlDataReader.GetOrdinal("codAreaTematica");
                            if (!sqlDataReader.IsDBNull(codAreaTematica_index))
                                resultAreaTematicas.CodAreaTematica = sqlDataReader.GetInt32(codAreaTematica_index);

                            int nombreAreaTematica_index = sqlDataReader.GetOrdinal("nombreAreaTematica");
                            if (!sqlDataReader.IsDBNull(nombreAreaTematica_index))
                                resultAreaTematicas.NombreAreaTematica = sqlDataReader.GetString(nombreAreaTematica_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultAreaTematicas.Estado = sqlDataReader.GetString(estado_index);


                            listAreaTematicas.Add(resultAreaTematicas);
                        }
                    }
                }
            }

            return listAreaTematicas;
        }

        public override AreaTematica find(AreaTematica areaTematica)
        {
            AreaTematica resultAreaTematicas = null;

            sqlQuery = "dbo.USP_AreaTematicas_SelectById";

            using (sqlConnection = new SqlConnection(getConnectionStrings()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codAreaTematica", areaTematica.CodAreaTematica);

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        while (sqlDataReader.Read())
                        {
                            resultAreaTematicas = new AreaTematica();
                            int codAreaTematica_index = sqlDataReader.GetOrdinal("codAreaTematica");
                            if (!sqlDataReader.IsDBNull(codAreaTematica_index))
                                resultAreaTematicas.CodAreaTematica = sqlDataReader.GetInt32(codAreaTematica_index);

                            int nombreAreaTematica_index = sqlDataReader.GetOrdinal("nombreAreaTematica");
                            if (!sqlDataReader.IsDBNull(nombreAreaTematica_index))
                                resultAreaTematicas.NombreAreaTematica = sqlDataReader.GetString(nombreAreaTematica_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultAreaTematicas.Estado = sqlDataReader.GetString(estado_index);

                        }
                    }
                }
            }

            return resultAreaTematicas;
        }

    }
}
