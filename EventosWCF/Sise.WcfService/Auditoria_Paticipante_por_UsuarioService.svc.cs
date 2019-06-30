using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Sise.Entities;
using Sise.WcfService.Entity;
using Sise.Business;

namespace Sise.WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Auditoria_Paticipante_por_UsuarioService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Auditoria_Paticipante_por_UsuarioService.svc o Auditoria_Paticipante_por_UsuarioService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Auditoria_Paticipante_por_UsuarioService : IAuditoria_Paticipante_por_UsuarioService
    {
        public ServiceResponse registrar(Auditoria_Paticipante_por_Usuario auditoriaparticipanteporusuario)
        {
            ServiceResponse result = new ServiceResponse();

            //validacion 
            if (String.IsNullOrWhiteSpace(auditoriaparticipanteporusuario.Email_usuario))
            {
                result.Message = "El campo Email es requerido.";
                return result;
            }
            if (auditoriaparticipanteporusuario.CodParticipante == 0)
            {
                result.Message = "El campo Participante es requerido.";
                return result;
            }
            if (auditoriaparticipanteporusuario.Fecha==null )
            {
                result.Message = "El campo Fecha es requerido.";
                return result;
            }
            if (String.IsNullOrWhiteSpace(auditoriaparticipanteporusuario.Accion))
            {
                result.Message = "El campo Accion es requerido.";
                return result;
            }

            //proceso
            try
            {
                if (new Auditoria_Paticipante_por_UsuarioBll().registrar(auditoriaparticipanteporusuario))
                {
                    result.IsSuccess = true;
                    result.Message = "Auditoria Participante por Usuario registrado correctamente";
                }
                else
                {
                    result.Message = "No podemos procesar su solicitud en este momento. Disculpe las molestias. Intente de nuevo más adelante";
                }
            }
            catch (Exception ex)
            {
                result.Message = "Ha ocurrido un error inesperado, contacte al administrador del sistema.";
                result.MessageDev = ex.Message;
            }

            return result;
        }
    }
}
