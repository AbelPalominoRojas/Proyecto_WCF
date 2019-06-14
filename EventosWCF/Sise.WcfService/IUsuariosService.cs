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
    public interface IUsuariosService
    {
        [OperationContract]
        Response<Usuario> registrar(Usuario usuario);

        [OperationContract]
        Response<Usuario> actualizar(Usuario usuario);

        [OperationContract]
        Response<Usuario> eliminar(Int32 CodUsuario);

        [OperationContract]
        Response<Usuario> listar();

        [OperationContract]
        Response<Usuario> buscar(Int32 CodUsuario);
    }
}
