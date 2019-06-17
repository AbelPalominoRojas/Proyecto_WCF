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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EventoParticipantesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EventoParticipantesService.svc or EventoParticipantesService.svc.cs at the Solution Explorer and start debugging.
    public class EventoParticipantesService : IEventoParticipantesService
    {
        public Response<EventoParticipante> actualizar(EventoParticipante eventoParticipante)
        {
            throw new NotImplementedException();
        }

        public Response<EventoParticipante> buscar(int CodEventoParticipante)
        {
            throw new NotImplementedException();
        }

        public Response<EventoParticipante> eliminar(int CodEventoParticipante)
        {
            throw new NotImplementedException();
        }

        public Response<EventoParticipante> listar()
        {
            throw new NotImplementedException();
        }

        public Response<EventoParticipante> registrar(EventoParticipante eventoParticipante)
        {
            throw new NotImplementedException();
        }
    }
}
