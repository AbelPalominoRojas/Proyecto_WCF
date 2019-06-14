using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Sise.Entities;
using Sise.WcfService.Entity;

namespace Sise.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UsuariosService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UsuariosService.svc or UsuariosService.svc.cs at the Solution Explorer and start debugging.
    public class UsuariosService : IUsuariosService
    {

        public Response<Usuario> registrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }
        public Response<Usuario> actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Response<Usuario> buscar(int CodUsuario)
        {
            throw new NotImplementedException();
        }

        public Response<Usuario> eliminar(int CodUsuario)
        {
            throw new NotImplementedException();
        }

        public Response<Usuario> listar()
        {
            throw new NotImplementedException();
        }

      
    }
}
