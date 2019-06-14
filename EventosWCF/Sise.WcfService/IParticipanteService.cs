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
        Response<Participante> registrar(Participante participante);

        [OperationContract]
        Response<Participante> actualizar(Participante participante);

        [OperationContract]
        Response<Participante> eliminar(Int32 CodParticipante);

        [OperationContract]
        Response<Participante> listar();

        [OperationContract]
        Response<Participante> buscar(Int32 CodParticipante);
    }
}
