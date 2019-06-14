
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class EventoParticipanteBll
    {

        public bool create(EventoParticipante eventoParticipante)
        {
            return new EventoParticipanteRepository().create(eventoParticipante);
        }

        public bool edit(EventoParticipante eventoParticipante)
        {
            return new EventoParticipanteRepository().edit(eventoParticipante);
        }

        public bool remove(EventoParticipante eventoParticipante)
        {
            return new EventoParticipanteRepository().remove(eventoParticipante);
        }

        public List<EventoParticipante> findAll()
        {
            return new EventoParticipanteRepository().findAll();
        }

        public EventoParticipante find(EventoParticipante eventoParticipante)
        {
            return new EventoParticipanteRepository().find(eventoParticipante);
        }

    }
}
