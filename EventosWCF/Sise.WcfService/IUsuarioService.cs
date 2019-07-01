using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Sise.WcfService.Entity;
using System.Data;
using Sise.Entities;
namespace Sise.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsuariosService" in both code and config file together.
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        ServiceResponse registrar(Usuario usuario);

        [OperationContract]
        ServiceResponse actualizar(Usuario usuario);

        [OperationContract]
        ServiceResponse eliminar(Int32 CodUsuario);

        [OperationContract]
        List<Usuario> listar();

        [OperationContract]
        Usuario buscar(Int32 CodUsuario);

        [OperationContract]
        Usuario login(String email, String password);
    }
}
