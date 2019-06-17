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
    public interface IEventoParticipanteService
    {
        [OperationContract]
        ServiceResponse registrar(EventoParticipante eventoParticipante);

        [OperationContract]
        ServiceResponse actualizar(EventoParticipante eventoParticipante);

        [OperationContract]
        ServiceResponse eliminar(Int32 CodEvento,Int32 CodParticipante);

        [OperationContract]
        List<EventoParticipante> listar();

        [OperationContract]
        EventoParticipante buscar(Int32 CodEvento, Int32 CodParticipante);
    }
}
