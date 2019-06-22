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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EventoParticipanteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EventoParticipanteService.svc or EventoParticipanteService.svc.cs at the Solution Explorer and start debugging.
    public class EventoParticipanteService : IEventoParticipanteService
    {
        public ServiceResponse actualizar(EventoParticipante eventoParticipante)
        {
            ServiceResponse result = new ServiceResponse();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar el actualizacion";

            //validacion 
            if (eventoParticipante.CodEvento == 0)
            {
                result.Message = "El campo CodEvento es requerido.";
                return result;
            }
            if (eventoParticipante.CodParticipante == 0)
            {
                result.Message = "El campo CodParticipante es requerido.";
                return result;
            }
            if (eventoParticipante.FechaRegistro == null)
            {
                result.Message = "El campo FechaRegistro es requerido.";
                return result;
            }
            if (eventoParticipante.ParticipanteAsistio == false)
            {
                result.Message = "El campo ParticipanteAsistio es requerido.";
                return result;
            }
            if (eventoParticipante.CodUsuario== 0)
            {
                result.Message = "El campo CodUsuario es requerido.";
                return result;
            }


            //proceso
            try
            {
                if (new EventoParticipanteBll().actualizar(eventoParticipante))
                {
                    result.IsSuccess = true;
                    result.Message = " Event Participante actualizado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public EventoParticipante buscar(int CodEvento, int CodParticipante)
        {
            EventoParticipante eventoParticipante = null;

            //proceso
            try
            {
                eventoParticipante = new EventoParticipanteBll().buscar(new EventoParticipante() { CodEvento = CodEvento , CodParticipante = CodParticipante });
             

            }
            catch (Exception ex)
            {

            }

            return eventoParticipante;
        }

        public ServiceResponse eliminar(int CodEvento, int CodParticipante)
        {
            ServiceResponse result = new ServiceResponse();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar la eliminacion";

            //validacion
            if (CodEvento == 0)
            {
                result.Message = "El codigo de Evento no es correcto.";
                return result;
            }
            if (CodParticipante == 0)
            {
                result.Message = "El codigo de Participante no es correcto.";
                return result;
            }

            //proceso
            try
            {
                if (new EventoParticipanteBll().eliminar(new EventoParticipante() { CodEvento = CodEvento , CodParticipante = CodParticipante }))
                {
                    result.IsSuccess = true;
                    result.Message = " Evento Participante eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public List<EventoParticipante> listar()
        {
            List<EventoParticipante> listEventoParticipante = new List<EventoParticipante>();

            try
            {
                listEventoParticipante = new EventoParticipanteBll().listar();
            }
            catch (Exception ex)
            {

            }

            return listEventoParticipante;
        }

        public ServiceResponse registrar(EventoParticipante eventoParticipante)
        {
            ServiceResponse result = new ServiceResponse();


            //validacion 
            if (eventoParticipante.CodEvento == 0)
            {
                result.Message = "El campo CodEvento es requerido.";
                return result;
            }
            if (eventoParticipante.CodParticipante == 0)
            {
                result.Message = "El campo CodParticipante es requerido.";
                return result;
            }
            if (eventoParticipante.FechaRegistro == null)
            {
                result.Message = "El campo FechaRegistro es requerido.";
                return result;
            }
            if (eventoParticipante.ParticipanteAsistio == false)
            {
                result.Message = "El campo ParticipanteAsistio es requerido.";
                return result;
            }
            if (eventoParticipante.CodUsuario== 0)
            {
                result.Message = "El campo CodUsuario es requerido.";
                return result;
            }


            //proceso
            try
            {
                if (new EventoParticipanteBll().registrar(eventoParticipante))
                {
                    result.IsSuccess = true;
                    result.Message = " EventoParticipante registrado correctamente";
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
