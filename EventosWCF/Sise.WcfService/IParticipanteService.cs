using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Sise.WcfService.Entity;
using Sise.Entities;

namespace Sise.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IParticipanteService" in both code and config file together.
    [ServiceContract]
    public interface IParticipanteService
    {
        [OperationContract]
        ServiceResponse registrar(Participante participante);

        [OperationContract]
        ServiceResponse actualizar(Participante participante);

        [OperationContract]
        ServiceResponse eliminar(Int32 CodParticipante);

        [OperationContract]
        List<Participante> listar();

        [OperationContract]
        Participante buscar(Int32 CodParticipante);
    }
}
