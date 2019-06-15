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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EventosService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EventosService.svc or EventosService.svc.cs at the Solution Explorer and start debugging.
    public class EventosService : IEventosService
    {

        public Response<Evento> registrar(Evento evento)
        {
            Response<Evento> result = new Response<Evento>();


            //validacion 
            if (evento.CodAreaTematica == 0)
            {
                result.Message = "El campo CodAreaTematica es requerido.";
                return result;
            }
            if (evento.NombreEvento.Trim().Length == 0)
            {
                result.Message = "El campo Apellidos es requerido.";
                return result;
            }
          
            

            //proceso
            try
            {
                if (new EventoBll().create(evento))
                {
                    result.IsSuccess = true;
                    result.Message = " Evento registrado correctamente";
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
        public Response<Evento> actualizar(Evento evento)
        {
            Response<Evento> result = new Response<Evento>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar el actualizacion";

            //validacion
            if (evento.CodEvento== 0)
            {
                result.Message = "El codigo de  evento no es correcto.";
                return result;
            }

            

            
            //proceso
            try
            {
                if (new EventoBll().edit(evento))
                {
                    result.IsSuccess = true;
                    result.Message = " Evento actualizado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<Evento> buscar(int CodEvento)
        {
            Response<Evento> result = new Response<Evento>();

            //validacion
            if (CodEvento == 0)
            {
                result.Message = "El codigo de Evento no es correcto.";
                return result;
            }


            //proceso
            try
            {
                var Evento = new EventoBll().find(new Evento() { CodEvento = CodEvento });

                if (Evento != null)
                {
                    result.Item = Evento;
                    result.IsSuccess = true;
                    result.Message = " Evento encontrado";
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

        public Response<Evento> eliminar(int CodEvento)
        {
            Response<Evento> result = new Response<Evento>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar la eliminacion";

            //validacion
            if (CodEvento == 0)
            {
                result.Message = "El codigo de Evento no es correcto.";
                return result;
            }


            //proceso
            try
            {
                if (new ParticipanteBll().remove(new Participante() { CodParticipante = CodParticipante }))
                {
                    result.IsSuccess = true;
                    result.Message = " Evento eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<Evento> listar()
        {
            Response<Evento> result = new Response<Evento>();

            try
            {
                result.Items = new EventoBll().findAll();
                result.IsSuccess = true;
                result.Message = "Listado de Eventos";
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
