using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Sise.Entities;
using Sise.WcfService.Entity;

namespace Sise.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEventoParticipantesService" in both code and config file together.
    [ServiceContract]
    public interface IEventoParticipantesService
    {
        [OperationContract]
        Response<EventoParticipante> registrar(EventoParticipante eventoParticipante);

        [OperationContract]
        Response<EventoParticipante> actualizar(EventoParticipante eventoParticipante);

        [OperationContract]
        Response<EventoParticipante> eliminar(Int32 CodEventoParticipante);

        [OperationContract]
        Response<EventoParticipante> listar();

        [OperationContract]
        Response<EventoParticipante> buscar(Int32 CodEventoParticipante);
    }
}
