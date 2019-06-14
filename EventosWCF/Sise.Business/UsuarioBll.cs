
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class UsuarioBll
    {

        public bool create(Usuario usuario)
        {
            return new UsuarioRepository().create(usuario);
        }

        public bool edit(Usuario usuario)
        {
            return new UsuarioRepository().edit(usuario);
        }

        public bool remove(Usuario usuario)
        {
            return new UsuarioRepository().remove(usuario);
        }

        public List<Usuario> findAll()
        {
            return new UsuarioRepository().findAll();
        }

        public Usuario find(Usuario usuario)
        {
            return new UsuarioRepository().find(usuario);
        }

    }
}
