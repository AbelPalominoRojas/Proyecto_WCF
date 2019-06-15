using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Sise.WcfService.Entity;
using Sise.Entities;

namespace Sise.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEventosService" in both code and config file together.
    [ServiceContract]
    public interface IEventosService
    {
        [OperationContract]
        Response<Evento> registrar(Evento evento);

        [OperationContract]
        Response<Evento> actualizar(Evento evento);

        [OperationContract]
        Response<Evento> eliminar(Int32 CodEvento);

        [OperationContract]
        Response<Evento> listar();

        [OperationContract]
        Response<Evento> buscar(Int32 CodEvento);
    }
}
