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
    public interface IEventoService
    {
        [OperationContract]
        ServiceResponse registrar(Evento evento);

        [OperationContract]
        ServiceResponse actualizar(Evento evento);

        [OperationContract]
        ServiceResponse eliminar(Int32 CodEvento);

        [OperationContract]
        List<Evento> listar();

        [OperationContract]
        Evento buscar(Int32 CodEvento);

        [OperationContract]
        List<Evento> buscarLista(Int32 codAreaTematica, DateTime? fechaDesde, DateTime? fechaHasta);
    }
}
