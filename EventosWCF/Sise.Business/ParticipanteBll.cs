
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class ParticipanteBll
    {

        public bool create(Participante participante)
        {
            return new ParticipanteRepository().create(participante);
        }

        public bool edit(Participante participante)
        {
            return new ParticipanteRepository().edit(participante);
        }

        public bool remove(Participante participante)
        {
            return new ParticipanteRepository().remove(participante);
        }

        public List<Participante> findAll()
        {
            return new ParticipanteRepository().findAll();
        }

        public Participante find(Participante participante)
        {
            return new ParticipanteRepository().find(participante);
        }

    }
}
