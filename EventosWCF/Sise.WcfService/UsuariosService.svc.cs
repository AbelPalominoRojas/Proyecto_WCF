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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UsuariosService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UsuariosService.svc or UsuariosService.svc.cs at the Solution Explorer and start debugging.
    public class UsuariosService : IUsuariosService
    {

        public Response<Usuario> registrar(Usuario usuario)
        {
            Response<Usuario> result = new Response<Usuario>();


            //validacion 
            if (usuario.Nombres.Trim().Length == 0)
            {
                result.Message = "El campo Nombres es requerido.";
                return result;
            }
            if (usuario.Apellidos.Trim().Length == 0)
            {
                result.Message = "El campo Apellidos es requerido.";
                return result;
            }
            if (usuario.Email.Trim().Length == 0)
            {
                result.Message = "El campo Email es requerido.";
                return result;
            }
            if (usuario.Password.Trim().Length == 0)
            {
                result.Message = "El campo Password es requerido.";
                return result;
            }
            
            //proceso
            try
            {
                if (new UsuarioBll().create(usuario))
                {
                    result.IsSuccess = true;
                    result.Message = "usuario registrado correctamente";
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
        public Response<Usuario> actualizar(Usuario usuario)
        {
            Response<Usuario> result = new Response<Usuario>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar el actualizacion";

            //validacion
            if (usuario.CodUsuario == 0)
            {
                result.Message = "El codigo de  Usuario no es correcto.";
                return result;
            }

            if (usuario.Nombres.Trim().Length == 0)
            {
                result.Message = "El campo Nombre es requerido.";
                return result;
            }
            if (usuario.Apellidos.Trim().Length == 0)
            {
                result.Message = "El campo Apellidos es requerido.";
                return result;
            }

            if (usuario.Email.Trim().Length == 0)
            {
                result.Message = "El campo Email es requerido.";
                return result;
            }
            if (usuario.Password.Trim().Length == 0)
            {
                result.Message = "El campo Password es requerido.";
                return result;
            }
           
            //proceso
            try
            {
                if (new UsuarioBll().edit(usuario))
                {
                    result.IsSuccess = true;
                    result.Message = " usuario actualizado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<Usuario> buscar(int CodUsuario)
        {
            Response<Usuario> result = new Response<Usuario>();

            //validacion
            if (CodUsuario == 0)
            {
                result.Message = "El codigo de usuario no es correcto.";
                return result;
            }


            //proceso
            try
            {
                var usuario = new UsuarioBll().find(new Usuario() { CodUsuario = CodUsuario });

                if (usuario != null)
                {
                    result.Item = usuario;
                    result.IsSuccess = true;
                    result.Message = " usuario encontrado";
                }
                else
                {
                    result.Message = "No se encontro datos.";
                }
            }
            catch (Exception ex)
            {
                //mensaje de error por defecto
                result.Message = "Ocurio un error!!!. No se encontro datos.";
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<Usuario> eliminar(int CodUsuario)
        {
            Response<Usuario> result = new Response<Usuario>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar la eliminacion";

            //validacion
            if (CodUsuario == 0)
            {
                result.Message = "El codigo de usuario no es correcto.";
                return result;
            }


            //proceso
            try
            {
                if (new UsuarioBll().remove(new Usuario() { CodUsuario = CodUsuario }))
                {
                    result.IsSuccess = true;
                    result.Message = " usuario eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<Usuario> listar()
        {

            Response<Usuario> result = new Response<Usuario>();

            try
            {
                result.Items = new UsuarioBll().findAll();
                result.IsSuccess = true;
                result.Message = "Listado de Usuario";
            }
            catch (Exception ex)
            {
                //mensaje de error por defecto
                result.Message = "Ocurio un error!!!. No se encontro datos.";
                result.MessageDev = ex.Message;
                //throw;
            }

            return result;
        }

    }


}
}
