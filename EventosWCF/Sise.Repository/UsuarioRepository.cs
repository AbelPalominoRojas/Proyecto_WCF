
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sise.Entities;
using System.Data;

namespace Sise.Repository
{
    public class UsuarioRepository : AbstractCrud<Usuario>
    {
        public override bool registrar(Usuario usuario)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Usuarios_Insert";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@codUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.AddWithValue("@nombres", usuario.Nombres);
                    sqlCommand.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                    sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
                    sqlCommand.Parameters.AddWithValue("@password", usuario.Password);
                    sqlCommand.Parameters.AddWithValue("@estado", "A");

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool actualizar(Usuario usuario)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Usuarios_Update";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codUsuario", usuario.CodUsuario);
                    sqlCommand.Parameters.AddWithValue("@nombres", usuario.Nombres);
                    sqlCommand.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                    sqlCommand.Parameters.AddWithValue("@email", usuario.Email);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override bool eliminar(Usuario usuario)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Usuarios_Delete";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codUsuario", usuario.CodUsuario);

                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }

        public override List<Usuario> listar()
        {
            List<Usuario> listUsuarios = new List<Usuario>();

            sqlQuery = "dbo.USP_Usuarios_SelectAll";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        Usuario resultUsuarios = null;

                        while (sqlDataReader.Read())
                        {
                            resultUsuarios = new Usuario();
                            int codUsuario_index = sqlDataReader.GetOrdinal("codUsuario");
                            if (!sqlDataReader.IsDBNull(codUsuario_index))
                                resultUsuarios.CodUsuario = sqlDataReader.GetInt32(codUsuario_index);

                            int nombres_index = sqlDataReader.GetOrdinal("nombres");
                            if (!sqlDataReader.IsDBNull(nombres_index))
                                resultUsuarios.Nombres = sqlDataReader.GetString(nombres_index);

                            int apellidos_index = sqlDataReader.GetOrdinal("apellidos");
                            if (!sqlDataReader.IsDBNull(apellidos_index))
                                resultUsuarios.Apellidos = sqlDataReader.GetString(apellidos_index);

                            int email_index = sqlDataReader.GetOrdinal("email");
                            if (!sqlDataReader.IsDBNull(email_index))
                                resultUsuarios.Email = sqlDataReader.GetString(email_index);
                            
                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultUsuarios.Estado = sqlDataReader.GetString(estado_index);



                            listUsuarios.Add(resultUsuarios);
                        }
                    }
                }
            }

            return listUsuarios;
        }

        public override Usuario buscar(Usuario usuario)
        {
            Usuario resultUsuarios = null;

            sqlQuery = "dbo.USP_Usuarios_SelectById";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@codUsuario", usuario.CodUsuario);

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        if (sqlDataReader.Read())
                        {
                            resultUsuarios = new Usuario();
                            int codUsuario_index = sqlDataReader.GetOrdinal("codUsuario");
                            if (!sqlDataReader.IsDBNull(codUsuario_index))
                                resultUsuarios.CodUsuario = sqlDataReader.GetInt32(codUsuario_index);

                            int nombres_index = sqlDataReader.GetOrdinal("nombres");
                            if (!sqlDataReader.IsDBNull(nombres_index))
                                resultUsuarios.Nombres = sqlDataReader.GetString(nombres_index);

                            int apellidos_index = sqlDataReader.GetOrdinal("apellidos");
                            if (!sqlDataReader.IsDBNull(apellidos_index))
                                resultUsuarios.Apellidos = sqlDataReader.GetString(apellidos_index);

                            int email_index = sqlDataReader.GetOrdinal("email");
                            if (!sqlDataReader.IsDBNull(email_index))
                                resultUsuarios.Email = sqlDataReader.GetString(email_index);
                            
                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultUsuarios.Estado = sqlDataReader.GetString(estado_index);



                        }
                    }
                }
            }

            return resultUsuarios;
        }

        public Usuario login(String email, String password)
        {
            Usuario resultUsuarios = null;

            sqlQuery = "dbo.USP_Usuarios_login";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@email", email);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult))
                    {

                        if (sqlDataReader.Read())
                        {
                            resultUsuarios = new Usuario();
                            int codUsuario_index = sqlDataReader.GetOrdinal("codUsuario");
                            if (!sqlDataReader.IsDBNull(codUsuario_index))
                                resultUsuarios.CodUsuario = sqlDataReader.GetInt32(codUsuario_index);

                            int nombres_index = sqlDataReader.GetOrdinal("nombres");
                            if (!sqlDataReader.IsDBNull(nombres_index))
                                resultUsuarios.Nombres = sqlDataReader.GetString(nombres_index);

                            int apellidos_index = sqlDataReader.GetOrdinal("apellidos");
                            if (!sqlDataReader.IsDBNull(apellidos_index))
                                resultUsuarios.Apellidos = sqlDataReader.GetString(apellidos_index);

                            int email_index = sqlDataReader.GetOrdinal("email");
                            if (!sqlDataReader.IsDBNull(email_index))
                                resultUsuarios.Email = sqlDataReader.GetString(email_index);

                            int estado_index = sqlDataReader.GetOrdinal("estado");
                            if (!sqlDataReader.IsDBNull(estado_index))
                                resultUsuarios.Estado = sqlDataReader.GetString(estado_index);



                        }
                    }
                }
            }

            return resultUsuarios;
        }


    }
}
