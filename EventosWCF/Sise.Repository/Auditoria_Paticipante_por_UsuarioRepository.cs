using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using Sise.Entities;
using System.Data;

namespace Sise.Repository
{
    public class Auditoria_Paticipante_por_UsuarioRepository : AbstractCrud<Auditoria_Paticipante_por_Usuario>
    {
        public override bool actualizar(Auditoria_Paticipante_por_Usuario entity)
        {
            throw new NotImplementedException();
        }

        public override Auditoria_Paticipante_por_Usuario buscar(Auditoria_Paticipante_por_Usuario entity)
        {
            throw new NotImplementedException();
        }

        public override bool eliminar(Auditoria_Paticipante_por_Usuario entity)
        {
            throw new NotImplementedException();
        }

        public override List<Auditoria_Paticipante_por_Usuario> listar()
        {
            throw new NotImplementedException();
        }

        public override bool registrar(Auditoria_Paticipante_por_Usuario auditoriaparticipanteporusuario)
        {
            bool result = false;

            sqlQuery = "dbo.USP_Auditoria_Paticipante_por_Usuario_Insert";

            using (sqlConnection = new SqlConnection(nombreConexcion()))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@email_usuario", auditoriaparticipanteporusuario.Email_usuario);
                    sqlCommand.Parameters.AddWithValue("@codParticipante", auditoriaparticipanteporusuario.CodParticipante);
                    sqlCommand.Parameters.AddWithValue("@fecha", auditoriaparticipanteporusuario.Fecha);
                    sqlCommand.Parameters.AddWithValue("@accion", auditoriaparticipanteporusuario.Accion);
                    result = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                }
            }

            return result;
        }
    }
}
