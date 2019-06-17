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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ParticipanteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ParticipanteService.svc or ParticipanteService.svc.cs at the Solution Explorer and start debugging.
    public class ParticipanteService : IParticipanteService
    {

        public Response<Participante> registrar(Participante participante)
        {
            Response<Participante> result = new Response<Participante>();


            //validacion 
            if (participante.Nombres.Trim().Length == 0)
            {
                result.Message = "El campo Nombres es requerido.";
                return result;
            }
            if (participante.Apellidos.Trim().Length == 0)
            {
                result.Message = "El campo Apellidos es requerido.";
                return result;
            }
            if (participante.Dni.Trim().Length == 0)
            {
                result.Message = "El campo Dni es requerido.";
                return result;
            }
            if (participante.Correo.Trim().Length == 0)
            {
                result.Message = "El campo Correo es requerido.";
                return result;
            }
            if (participante.CodTipoParticipante == 0)
            {
                result.Message = "El campo CodTipoParticipante es requerido.";
                return result;
            }

            //proceso
            try
            {
                if (new ParticipanteBll().registrar(participante))
                {
                    result.IsSuccess = true;
                    result.Message = "Participante registrado correctamente";
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
        public Response<Participante> actualizar(Participante participante)
        {
            Response<Participante> result = new Response<Participante>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar el actualizacion";

            //validacion
            if (participante.CodParticipante == 0)
            {
                result.Message = "El codigo de  Participante no es correcto.";
                return result;
            }

            if (participante.Nombres.Trim().Length == 0)
            {
                result.Message = "El campo Nombre es requerido.";
                return result;
            }
            if (participante.Apellidos.Trim().Length == 0)
            {
                result.Message = "El campo Apellidos es requerido.";
                return result;
            }

            if (participante.Dni.Trim().Length == 0)
            {
                result.Message = "El campo Dni es requerido.";
                return result;
            }
            if (participante.Correo.Trim().Length == 0)
            {
                result.Message = "El campo Correo es requerido.";
                return result;
            }
            if (participante.CodTipoParticipante == 0)
            {
                result.Message = "El campo CodTipoParticipante es requerido.";
                return result;
            }
            //proceso
            try
            {
                if (new ParticipanteBll().actualizar(participante))
                {
                    result.IsSuccess = true;
                    result.Message = " Participante actualizado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<Participante> buscar(int CodParticipante)
        {
            Response<Participante> result = new Response<Participante>();

            //validacion
            if (CodParticipante == 0)
            {
                result.Message = "El codigo de Participante no es correcto.";
                return result;
            }


            //proceso
            try
            {
                var Participante = new ParticipanteBll().buscar(new Participante() { CodParticipante = CodParticipante });

                if (Participante != null)
                {
                    result.Item = Participante;
                    result.IsSuccess = true;
                    result.Message = " Participantes encontrado";
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

        public Response<Participante> eliminar(int CodParticipante)
        {
            Response<Participante> result = new Response<Participante>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar la eliminacion";

            //validacion
            if (CodParticipante == 0)
            {
                result.Message = "El codigo de Participante no es correcto.";
                return result;
            }


            //proceso
            try
            {
                if (new ParticipanteBll().eliminar(new Participante() { CodParticipante = CodParticipante }))
                {
                    result.IsSuccess = true;
                    result.Message = " Participante eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<Participante> listar()
        {
            Response<Participante> result = new Response<Participante>();

            try
            {
                result.Items = new ParticipanteBll().listar();
                result.IsSuccess = true;
                result.Message = "Listado de Participante";
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
