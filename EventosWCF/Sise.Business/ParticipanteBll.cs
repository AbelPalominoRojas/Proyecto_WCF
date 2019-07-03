
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class ParticipanteBll
    {

        public bool registrar(Participante participante)
        {
            return new ParticipanteRepository().registrar(participante);
        }

        public bool actualizar(Participante participante)
        {
            return new ParticipanteRepository().actualizar(participante);
        }

        public bool eliminar(Participante participante)
        {
            return new ParticipanteRepository().eliminar(participante);
        }

        public List<Participante> listar()
        {
            return new ParticipanteRepository().listar();
        }

        public Participante buscar(Participante participante)
        {
            return new ParticipanteRepository().buscar(participante);
        }

        public List<Participante> buscarLista(Participante participante)
        {
            return new ParticipanteRepository().buscarLista(participante);
        }

    }
}
