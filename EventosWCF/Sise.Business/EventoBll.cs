
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class EventoBll
    {

        public bool create(Evento evento)
        {
            return new EventoRepository().create(evento);
        }

        public bool edit(Evento evento)
        {
            return new EventoRepository().edit(evento);
        }

        public bool remove(Evento evento)
        {
            return new EventoRepository().remove(evento);
        }

        public List<Evento> findAll()
        {
            return new EventoRepository().findAll();
        }

        public Evento find(Evento evento)
        {
            return new EventoRepository().find(evento);
        }

    }
}
