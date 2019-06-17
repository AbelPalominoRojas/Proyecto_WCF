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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TipoParticipantesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TipoParticipantesService.svc or TipoParticipantesService.svc.cs at the Solution Explorer and start debugging.
    public class TipoParticipantesService : ITipoParticipantesService
    {

        public Response<TipoParticipante> registrar(TipoParticipante tipoParticipantes)
        {
            Response<TipoParticipante> result = new Response<TipoParticipante>();

            
            //validacion 
            if (tipoParticipantes.NombreTipoParticipante.Trim().Length == 0)
            {
                result.Message = "El campo NombreTipoParticipante es requerido.";
                return result;
            }


            //proceso
            try
            {
                if (new TipoParticipanteBll().registrar(tipoParticipantes))
                {
                    result.IsSuccess = true;
                    result.Message = "Tipo Participantes registrado correctamente";
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
        public Response<TipoParticipante> actualizar(TipoParticipante tipoParticipantes)
        {
            Response<TipoParticipante> result = new Response<TipoParticipante>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar el actualizacion";

            //validacion
            if (tipoParticipantes.CodTipoParticipante == 0)
            {
                result.Message = "El codigo de Tipo Participante no es correcto.";
                return result;
            }

            if (tipoParticipantes.NombreTipoParticipante.Trim().Length == 0)
            {
                result.Message = "El campo NombreTipoParticipante es requerido.";
                return result;
            }


            //proceso
            try
            {
                if (new TipoParticipanteBll().actualizar(tipoParticipantes))
                {
                    result.IsSuccess = true;
                    result.Message = " Tipo Participante actualizado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<TipoParticipante> buscar(int CodTipoParticipantes)
        {
            Response<TipoParticipante> result = new Response<TipoParticipante>();

            //validacion
            if (CodTipoParticipantes == 0)
            {
                result.Message = "El codigo de Tipo Participante no es correcto.";
                return result;
            }


            //proceso
            try
            {
                var tipoParticipantes = new TipoParticipanteBll().buscar(new TipoParticipante() { CodTipoParticipante = CodTipoParticipantes });

                if (tipoParticipantes != null)
                {
                    result.Item = tipoParticipantes;
                    result.IsSuccess = true;
                    result.Message = "Tipo Participantes encontrado";
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

        public Response<TipoParticipante> eliminar(int CodTipoParticipantes)
        {
            Response<TipoParticipante> result = new Response<TipoParticipante>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar la eliminacion";

            //validacion
            if (CodTipoParticipantes == 0)
            {
                result.Message = "El codigo de Tipo Participante no es correcto.";
                return result;
            }


            //proceso
            try
            {
                if (new TipoParticipanteBll().eliminar(new TipoParticipante() { CodTipoParticipante = CodTipoParticipantes }))
                {
                    result.IsSuccess = true;
                    result.Message = " Tipo Participante eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }


        public Response<TipoParticipante> listar()
        {
            Response<TipoParticipante> result = new Response<TipoParticipante>();

            try
            {
                result.Items = new TipoParticipanteBll().listar();
                result.IsSuccess = true;
                result.Message = "Listado de Tipo Participante";
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
