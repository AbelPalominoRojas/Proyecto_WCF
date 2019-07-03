
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sise.Entities;
using System.Data;

namespace Sise.Repository
{
    public class ParticipanteRepository : AbstractCrud<Participante>
    {
        public override bool registrar(Participante participante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Participantes_Insert";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@codParticipante", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.AddWithValue("@nombres", participante.Nombres);
                    sqlCommand.Parameters.AddWithValue("@apellidos", participante.Apellidos);
                    sqlCommand.Parameters.AddWithValue("@dni", participante.Dni);
                    sqlCommand.Parameters.AddWithValue("@fechaNac", participante.FechaNac);
                    sqlCommand.Parameters.AddWithValue("@direccion", participante.Direccion);
                    sqlCommand.Parameters.AddWithValue("@correo", participante.Correo);
                    sqlCommand.Parameters.AddWithValue("@telefono", participante.Telefono);
                    sqlCommand.Parameters.AddWithValue("@distrito", participante.Distrito);
                    sqlCommand.Parameters.AddWithValue("@codTipoParticipante", participante.CodTipoParticipante);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool actualizar(Participante participante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Participantes_Update";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codParticipante", participante.CodParticipante);
                    sqlCommand.Parameters.AddWithValue("@nombres", participante.Nombres);
                    sqlCommand.Parameters.AddWithValue("@apellidos", participante.Apellidos);
                    sqlCommand.Parameters.AddWithValue("@dni", participante.Dni);
                    sqlCommand.Parameters.AddWithValue("@fechaNac", participante.FechaNac);
                    sqlCommand.Parameters.AddWithValue("@direccion", participante.Direccion);
                    sqlCommand.Parameters.AddWithValue("@correo", participante.Correo);
                    sqlCommand.Parameters.AddWithValue("@telefono", participante.Telefono);
                    sqlCommand.Parameters.AddWithValue("@distrito", participante.Distrito);
                    sqlCommand.Parameters.AddWithValue("@codTipoParticipante", participante.CodTipoParticipante);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool eliminar(Participante participante)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Participantes_Delete";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codParticipante", participante.CodParticipante);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override List<Participante> listar()
        {
            List<Participante> listParticipantes = new List<Participante>();

            sqlQuery = "dbo.USP_Participantes_SelectAll";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        while (sqlDataReader.Read())
                        {
                            listParticipantes.Add(setParticipante(sqlDataReader));
                        }
                    }
                }
            }

            return listParticipantes;
        }

        public override Participante buscar(Participante participante)
        {
            Participante resultParticipantes = null;

            sqlQuery = "dbo.USP_Participantes_SelectById";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codParticipante", participante.CodParticipante);

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        if (sqlDataReader.Read())
                        {
                            resultParticipantes = setParticipante(sqlDataReader);
                        }
                    }
                }
            }

            return resultParticipantes;
        }

        public List<Participante> buscarLista(Participante participante)
        {
            List<Participante> listParticipantes = new List<Participante>();

            sqlQuery = "dbo.USP_Participantes_Search";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@nombres", participante.Nombres);
                    sqlCommand.Parameters.AddWithValue("@apellidos", participante.Apellidos);
                    sqlCommand.Parameters.AddWithValue("@dni", participante.Dni);

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        while (sqlDataReader.Read())
                        {
                            listParticipantes.Add(setParticipante(sqlDataReader));
                        }
                    }
                }
            }

            return listParticipantes;
        }


        private Participante setParticipante(IDataReader sqlDataReader)
        {
            Participante resultParticipantes = new Participante();
            TipoParticipante tipoParticipante = new TipoParticipante();

            int codParticipante_index = sqlDataReader.GetOrdinal("codParticipante");
            if (!sqlDataReader.IsDBNull(codParticipante_index))
                resultParticipantes.CodParticipante = sqlDataReader.GetInt32(codParticipante_index);

            int nombres_index = sqlDataReader.GetOrdinal("nombres");
            if (!sqlDataReader.IsDBNull(nombres_index))
                resultParticipantes.Nombres = sqlDataReader.GetString(nombres_index);

            int apellidos_index = sqlDataReader.GetOrdinal("apellidos");
            if (!sqlDataReader.IsDBNull(apellidos_index))
                resultParticipantes.Apellidos = sqlDataReader.GetString(apellidos_index);

            int dni_index = sqlDataReader.GetOrdinal("dni");
            if (!sqlDataReader.IsDBNull(dni_index))
                resultParticipantes.Dni = sqlDataReader.GetString(dni_index);

            int fechaNac_index = sqlDataReader.GetOrdinal("fechaNac");
            if (!sqlDataReader.IsDBNull(fechaNac_index))
                resultParticipantes.FechaNac = sqlDataReader.GetDateTime(fechaNac_index);

            int direccion_index = sqlDataReader.GetOrdinal("direccion");
            if (!sqlDataReader.IsDBNull(direccion_index))
                resultParticipantes.Direccion = sqlDataReader.GetString(direccion_index);

            int correo_index = sqlDataReader.GetOrdinal("correo");
            if (!sqlDataReader.IsDBNull(correo_index))
                resultParticipantes.Correo = sqlDataReader.GetString(correo_index);

            int telefono_index = sqlDataReader.GetOrdinal("telefono");
            if (!sqlDataReader.IsDBNull(telefono_index))
                resultParticipantes.Telefono = sqlDataReader.GetString(telefono_index);

            int distrito_index = sqlDataReader.GetOrdinal("distrito");
            if (!sqlDataReader.IsDBNull(distrito_index))
                resultParticipantes.Distrito = sqlDataReader.GetString(distrito_index);

            int codTipoParticipante_index = sqlDataReader.GetOrdinal("codTipoParticipante");
            if (!sqlDataReader.IsDBNull(codTipoParticipante_index))
            {
                resultParticipantes.CodTipoParticipante = sqlDataReader.GetInt32(codTipoParticipante_index);
                tipoParticipante.CodTipoParticipante = resultParticipantes.CodTipoParticipante;
            }

            int nombreTipoParticipante_index = sqlDataReader.GetOrdinal("nombreTipoParticipante");
            if (!sqlDataReader.IsDBNull(nombreTipoParticipante_index))
                tipoParticipante.NombreTipoParticipante = sqlDataReader.GetString(nombreTipoParticipante_index);

            resultParticipantes.TipoParticipante = tipoParticipante;


            return resultParticipantes;
        }
    }
}
