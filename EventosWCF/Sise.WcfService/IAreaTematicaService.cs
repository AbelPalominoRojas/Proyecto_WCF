using Sise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sise.WcfService.Entity;

namespace Sise.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAreaTematicaService" in both code and config file together.
    [ServiceContract]
    interface IAreaTematicaService
    {
        [OperationContract]
        Response<AreaTematica> registrar(AreaTematica areaTematica);

        [OperationContract]
        Response<AreaTematica> actualizar(AreaTematica areaTematica);

        [OperationContract]
        Response<AreaTematica> eliminar(Int32 CodAreaTematica);

        [OperationContract]
        Response<AreaTematica> listar();

        [OperationContract]
        Response<AreaTematica> buscar(Int32 CodAreaTematica);
    }

}
