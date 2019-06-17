
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class EventoBll
    {

        public bool registrar(Evento evento)
        {
            return new EventoRepository().registrar(evento);
        }

        public bool actualizar(Evento evento)
        {
            return new EventoRepository().actualizar(evento);
        }

        public bool eliminar(Evento evento)
        {
            return new EventoRepository().eliminar(evento);
        }

        public List<Evento> listar()
        {
            return new EventoRepository().listar();
        }

        public Evento buscar(Evento evento)
        {
            return new EventoRepository().buscar(evento);
        }

    }
}
