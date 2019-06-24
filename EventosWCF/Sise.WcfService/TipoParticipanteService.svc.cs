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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TipoParticipanteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TipoParticipanteService.svc or TipoParticipanteService.svc.cs at the Solution Explorer and start debugging.
    public class TipoParticipanteService : ITipoParticipanteService
    {

        public ServiceResponse registrar(TipoParticipante tipoParticipantes)
        {
            ServiceResponse result = new ServiceResponse();


            //validacion 
            if (String.IsNullOrWhiteSpace(tipoParticipantes.NombreTipoParticipante))
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
        public ServiceResponse actualizar(TipoParticipante tipoParticipantes)
        {
            ServiceResponse result = new ServiceResponse();

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

        public TipoParticipante buscar(int CodTipoParticipantes)
        {
            TipoParticipante tipoParticipante = null;

            try
            {
                tipoParticipante = new TipoParticipanteBll().buscar(new TipoParticipante() { CodTipoParticipante = CodTipoParticipantes });
            }
            catch (Exception ex)
            {

            }

            return tipoParticipante;
        }

        public ServiceResponse eliminar(int CodTipoParticipantes)
        {
            ServiceResponse result = new ServiceResponse();

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


        public List<TipoParticipante> listar()
        {
            List<TipoParticipante> listTipoParticipante = new List<TipoParticipante>();

            try
            {
                listTipoParticipante = new TipoParticipanteBll().listar();
            }
            catch (Exception ex)
            {

            }

            return listTipoParticipante;
        }

    }

}
