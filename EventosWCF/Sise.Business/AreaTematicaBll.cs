
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class AreaTematicaBll
    {

        public bool registrar(AreaTematica areaTematica)
        {
            return new AreaTematicaRepository().registrar(areaTematica);
        }

        public bool actualizar(AreaTematica areaTematica)
        {
            return new AreaTematicaRepository().actualizar(areaTematica);
        }

        public bool eliminar(AreaTematica areaTematica)
        {
            return new AreaTematicaRepository().eliminar(areaTematica);
        }

        public List<AreaTematica> listar()
        {
            return new AreaTematicaRepository().listar();
        }

        public AreaTematica buscar(AreaTematica areaTematica)
        {
            return new AreaTematicaRepository().buscar(areaTematica);
        }

    }
}
