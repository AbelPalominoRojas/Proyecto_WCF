
using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class UsuarioBll
    {

        public bool registrar(Usuario usuario)
        {
            return new UsuarioRepository().registrar(usuario);
        }

        public bool actualizar(Usuario usuario)
        {
            return new UsuarioRepository().actualizar(usuario);
        }

        public bool eliminar(Usuario usuario)
        {
            return new UsuarioRepository().eliminar(usuario);
        }

        public List<Usuario> listar()
        {
            return new UsuarioRepository().listar();
        }

        public Usuario buscar(Usuario usuario)
        {
            return new UsuarioRepository().buscar(usuario);
        }

    }
}
