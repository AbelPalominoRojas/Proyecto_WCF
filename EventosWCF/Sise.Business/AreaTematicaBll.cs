
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class AreaTematicaBll
    {

        public bool create(AreaTematica areaTematica)
        {
            return new AreaTematicaRepository().create(areaTematica);
        }

        public bool edit(AreaTematica areaTematica)
        {
            return new AreaTematicaRepository().edit(areaTematica);
        }

        public bool remove(AreaTematica areaTematica)
        {
            return new AreaTematicaRepository().remove(areaTematica);
        }

        public List<AreaTematica> findAll()
        {
            return new AreaTematicaRepository().findAll();
        }

        public AreaTematica find(AreaTematica areaTematica)
        {
            return new AreaTematicaRepository().find(areaTematica);
        }

    }
}
