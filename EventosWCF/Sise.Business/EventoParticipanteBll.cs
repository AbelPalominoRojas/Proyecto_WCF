
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class EventoParticipanteBll
    {

        public bool registrar(EventoParticipante eventoParticipante)
        {
            return new EventoParticipanteRepository().registrar(eventoParticipante);
        }

        public bool actualizar(EventoParticipante eventoParticipante)
        {
            return new EventoParticipanteRepository().actualizar(eventoParticipante);
        }

        public bool eliminar(EventoParticipante eventoParticipante)
        {
            return new EventoParticipanteRepository().eliminar(eventoParticipante);
        }

        public List<EventoParticipante> listar()
        {
            return new EventoParticipanteRepository().listar();
        }

        public EventoParticipante buscar(EventoParticipante eventoParticipante)
        {
            return new EventoParticipanteRepository().buscar(eventoParticipante);
        }

    }
}
