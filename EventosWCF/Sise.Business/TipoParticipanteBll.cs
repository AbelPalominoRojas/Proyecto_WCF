
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class TipoParticipanteBll
    {

        public bool registrar(TipoParticipante tipoParticipante)
        {
            return new TipoParticipanteRepository().registrar(tipoParticipante);
        }

        public bool actualizar(TipoParticipante tipoParticipante)
        {
            return new TipoParticipanteRepository().actualizar(tipoParticipante);
        }

        public bool eliminar(TipoParticipante tipoParticipante)
        {
            return new TipoParticipanteRepository().eliminar(tipoParticipante);
        }

        public List<TipoParticipante> listar()
        {
            return new TipoParticipanteRepository().listar();
        }

        public TipoParticipante buscar(TipoParticipante tipoParticipante)
        {
            return new TipoParticipanteRepository().buscar(tipoParticipante);
        }

    }
}
