
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class TipoParticipanteBll
    {

        public bool create(TipoParticipante tipoParticipante)
        {
            return new TipoParticipanteRepository().create(tipoParticipante);
        }

        public bool edit(TipoParticipante tipoParticipante)
        {
            return new TipoParticipanteRepository().edit(tipoParticipante);
        }

        public bool remove(TipoParticipante tipoParticipante)
        {
            return new TipoParticipanteRepository().remove(tipoParticipante);
        }

        public List<TipoParticipante> findAll()
        {
            return new TipoParticipanteRepository().findAll();
        }

        public TipoParticipante find(TipoParticipante tipoParticipante)
        {
            return new TipoParticipanteRepository().find(tipoParticipante);
        }

    }
}
