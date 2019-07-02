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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UsuarioService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UsuarioService.svc or UsuarioService.svc.cs at the Solution Explorer and start debugging.
    public class UsuarioService : IUsuarioService
    {

        public ServiceResponse registrar(Usuario usuario)
        {
            ServiceResponse result = new ServiceResponse();


            //validacion 
            if (String.IsNullOrWhiteSpace(usuario.Nombres))
            {
                result.Message = "El campo Nombres es requerido.";
                return result;
            }
            if (String.IsNullOrWhiteSpace(usuario.Apellidos))
            {
                result.Message = "El campo Apellidos es requerido.";
                return result;
            }
            if (String.IsNullOrWhiteSpace(usuario.Email))
            {
                result.Message = "El campo Email es requerido.";
                return result;
            }
            if (String.IsNullOrWhiteSpace(usuario.Password))
            {
                result.Message = "El campo Password es requerido.";
                return result;
            }

            //proceso
            try
            {
                if (new UsuarioBll().registrar(usuario))
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
        public ServiceResponse actualizar(Usuario usuario)
        {
            ServiceResponse result = new ServiceResponse();

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

            //proceso
            try
            {
                if (new UsuarioBll().actualizar(usuario))
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

        public Usuario buscar(int CodUsuario)
        {
            Usuario usuario = null;

            try
            {
                usuario = new UsuarioBll().buscar(new Usuario() { CodUsuario = CodUsuario });

            }
            catch (Exception ex)
            {

            }

            return usuario;
        }

        public ServiceResponse eliminar(int CodUsuario)
        {
            ServiceResponse result = new ServiceResponse();

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
                if (new UsuarioBll().eliminar(new Usuario() { CodUsuario = CodUsuario }))
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

        public List<Usuario> listar()
        {
            List<Usuario> listUsuario = new List<Usuario>();

            try
            {
                listUsuario = new UsuarioBll().listar();
            }
            catch (Exception ex)
            {
                //throw;
            }

            return listUsuario;
        }

        public Usuario login(string email, string password)
        {
            Usuario usuario = null;
                try
            {
                usuario = new UsuarioBll().login(email,password);
            }
            catch (Exception ex)
            {

                //throw;
            }
            return usuario;
        }
    }



}
