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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EventoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EventoService.svc or EventoService.svc.cs at the Solution Explorer and start debugging.
    public class EventoService : IEventoService
    {

        public ServiceResponse registrar(Evento evento)
        {
            ServiceResponse result = new ServiceResponse();


            //validacion 
            if (evento.CodAreaTematica == 0)
            {
                result.Message = "El campo CodAreaTematica es requerido.";
                return result;
            }
            if (evento.NombreEvento.Trim().Length == 0)
            {
                result.Message = "El campo NombreEvento es requerido.";
                return result;
            }
            if (evento.DescripcionEvento.Trim().Length == 0)
            {
                result.Message = "El campo DescripcionEvento es requerido.";
                return result;
            }
            if (evento.FechaEvento == null)
            {
                result.Message = "El campo FechaEvento es requerido.";
                return result;
            }
            if (evento.Expositor.Trim().Length == 0)
            {
                result.Message = "El campo Expositor es requerido.";
                return result;
            }


            if (evento.LugarEvento.Trim().Length == 0)
            {
                result.Message = "El campo LugarEvento es requerido.";
                return result;
            }

            if (evento.LimiteParticipantes == 0)
            {
                result.Message = "El campo LimiteParticipantes es requerido.";
                return result;
            }

            if (evento.LugaresDisponibles == 0)
            {
                result.Message = "El campo LugaresDisponibles es requerido.";
                return result;
            }

            if (evento.CodUsuario == 0)
            {
                result.Message = "El campo CodUsuario es requerido.";
                return result;
            }



            //proceso
            try
            {
                if (new EventoBll().registrar(evento))
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
        public ServiceResponse actualizar(Evento evento)
        {
            ServiceResponse result = new ServiceResponse();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar el actualizacion";

            //validacion
            if (evento.CodEvento== 0)
            {
                result.Message = "El codigo de  evento no es correcto.";
                return result;
            }
            if (evento.CodAreaTematica == 0)
            {
                result.Message = "El campo CodAreaTematica es requerido.";
                return result;
            }
            if (evento.NombreEvento.Trim().Length == 0)
            {
                result.Message = "El campo NombreEvento es requerido.";
                return result;
            }
            if (evento.DescripcionEvento.Trim().Length == 0)
            {
                result.Message = "El campo DescripcionEvento es requerido.";
                return result;
            }
            if (evento.FechaEvento == null)
            {
                result.Message = "El campo FechaEvento es requerido.";
                return result;
            }
            if (evento.Expositor.Trim().Length == 0)
            {
                result.Message = "El campo Expositor es requerido.";
                return result;
            }


            if (evento.LugarEvento.Trim().Length == 0)
            {
                result.Message = "El campo LugarEvento es requerido.";
                return result;
            }

            if (evento.LimiteParticipantes == 0)
            {
                result.Message = "El campo LimiteParticipantes es requerido.";
                return result;
            }

            if (evento.LugaresDisponibles == 0)
            {
                result.Message = "El campo LugaresDisponibles es requerido.";
                return result;
            }

            if (evento.CodUsuario == 0)
            {
                result.Message = "El campo CodUsuario es requerido.";
                return result;
            }



            //proceso
            try
            {
                if (new EventoBll().actualizar(evento))
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

        public Evento buscar(int CodEvento)
        {
            Evento evento = null;
            try
            {
                evento = new EventoBll().buscar(new Evento() { CodEvento = CodEvento });
            }
            catch (Exception ex)
            {

            }

            return evento;
        }

        public ServiceResponse eliminar(int CodEvento)
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


            //proceso
            try
            {
                if (new EventoBll().eliminar(new Evento() { CodEvento = CodEvento } )) 
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

        public List<Evento> listar()
        {
            List<Evento> listEvento = new List<Evento>();

            try
            {
                listEvento = new EventoBll().listar();
            }
            catch (Exception ex)
            {

            }

            return listEvento;
        }

       
    }
}
