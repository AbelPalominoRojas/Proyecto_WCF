using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sise.Business;
using Sise.Entities;
using Sise.WcfService.Entity;

namespace Sise.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AreaTematicaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AreaTematicaService.svc or AreaTematicaService.svc.cs at the Solution Explorer and start debugging.
    public class AreaTematicaService : IAreaTematicaService
    {
        public ServiceResponse registrar(AreaTematica areaTematica)
        {
            ServiceResponse result = new ServiceResponse();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar el registro";

            //validacion 
            if (areaTematica.NombreAreaTematica.Trim().Length == 0)
            {
                result.Message = "El campo NombreAreaTematica es requerido.";
                return result;
            }


            //proceso
            try
            {
                if (new AreaTematicaBll().registrar(areaTematica))
                {
                    result.IsSuccess = true;
                    result.Message = "Area Tematica registrado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public ServiceResponse actualizar(AreaTematica areaTematica)
        {

            ServiceResponse result = new ServiceResponse();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar el actualizacion";

            //validacion
            if (areaTematica.CodAreaTematica == 0)
            {
                result.Message = "El codigo de area tematica no es correcto.";
                return result;
            }

            if (areaTematica.NombreAreaTematica.Trim().Length == 0)
            {
                result.Message = "El campo NombreAreaTematica es requerido.";
                return result;
            }


            //proceso
            try
            {
                if (new AreaTematicaBll().actualizar(areaTematica))
                {
                    result.IsSuccess = true;
                    result.Message = "Area Tematica actualizado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public AreaTematica buscar(int CodAreaTematica)
        {
            AreaTematica areaTematica = null;

            //proceso
            try
            {
                 areaTematica = new AreaTematicaBll().buscar(new AreaTematica() { CodAreaTematica = CodAreaTematica });
                
            }
            catch (Exception ex)
            {
               
            }

            return areaTematica;
        }

        public List<AreaTematica> listar()
        {
            List<AreaTematica> listAreaTematica = new List<AreaTematica>();

            try
            {
                listAreaTematica = new AreaTematicaBll().listar();
            }
            catch (Exception ex)
            {

                //throw;
            }

            return listAreaTematica;
        }

        public ServiceResponse eliminar(int CodAreaTematica)
        {
            ServiceResponse result = new ServiceResponse();
            

            //validacion
            if (CodAreaTematica == 0)
            {
                result.Message = "El codigo de area tematica no es correcto.";
                return result;
            }


            //proceso
            try
            {
                if (new AreaTematicaBll().eliminar(new AreaTematica() { CodAreaTematica = CodAreaTematica }))
                {
                    result.IsSuccess = true;
                    result.Message = "Area Tematica eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
                result.Message = "Ocurio un error!!!. No se pudo realizar la eliminacion";
            }

            return result;
        }

    }
}
