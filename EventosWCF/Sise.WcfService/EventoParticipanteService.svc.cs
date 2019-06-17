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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EventoParticipanteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EventoParticipanteService.svc or EventoParticipanteService.svc.cs at the Solution Explorer and start debugging.
    public class EventoParticipanteService : IEventoParticipanteService
    {
        public ServiceResponse actualizar(EventoParticipante eventoParticipante)
        {
            throw new NotImplementedException();
        }

        public EventoParticipante buscar(int CodEvento, int CodParticipante)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse eliminar(int CodEvento, int CodParticipante)
        {
            throw new NotImplementedException();
        }

        public List<EventoParticipante> listar()
        {
            throw new NotImplementedException();
        }

        public ServiceResponse registrar(EventoParticipante eventoParticipante)
        {
            throw new NotImplementedException();
        }
    }
}
