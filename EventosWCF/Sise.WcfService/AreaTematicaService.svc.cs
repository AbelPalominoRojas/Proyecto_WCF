﻿using System;
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
        public Response<AreaTematica> registrar(AreaTematica areaTematica)
        {
            Response<AreaTematica> result = new Response<AreaTematica>();

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
                if (new AreaTematicaBll().create(areaTematica))
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

        public Response<AreaTematica> actualizar(AreaTematica areaTematica)
        {

            Response<AreaTematica> result = new Response<AreaTematica>();

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
                if (new AreaTematicaBll().edit(areaTematica))
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

        public Response<AreaTematica> buscar(int CodAreaTematica)
        {
            Response<AreaTematica> result = new Response<AreaTematica>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se encontro datos.";

            //validacion
            if (CodAreaTematica == 0)
            {
                result.Message = "El codigo de area tematica no es correcto.";
                return result;
            }


            //proceso
            try
            {
                var areaTematica = new AreaTematicaBll().find(new AreaTematica() { CodAreaTematica = CodAreaTematica });

                if (areaTematica != null)
                {
                    result.Item = areaTematica;
                    result.IsSuccess = true;
                    result.Message = "Area Tematica encontrado";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

        public Response<AreaTematica> listar()
        {
            Response<AreaTematica> result = new Response<AreaTematica>();

            try
            {
                result.Items = new AreaTematicaBll().findAll();
                result.IsSuccess = true;
                result.Message = "Listado de area tematica";
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

        public Response<AreaTematica> eliminar(int CodAreaTematica)
        {
            Response<AreaTematica> result = new Response<AreaTematica>();

            //mensaje de error por defecto
            result.Message = "Ocurio un error!!!. No se pudo realizar la eliminacion";

            //validacion
            if (CodAreaTematica == 0)
            {
                result.Message = "El codigo de area tematica no es correcto.";
                return result;
            }


            //proceso
            try
            {
                if (new AreaTematicaBll().remove(new AreaTematica() { CodAreaTematica = CodAreaTematica }))
                {
                    result.IsSuccess = true;
                    result.Message = "Area Tematica eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                result.MessageDev = ex.Message;
            }

            return result;
        }

    }
}
