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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITipoParticipantesService" in both code and config file together.
    [ServiceContract]
    public interface ITipoParticipanteService
    {
        [OperationContract]
        ServiceResponse registrar(TipoParticipante tipoParticipantes);

        [OperationContract]
        ServiceResponse actualizar(TipoParticipante tipoParticipantes);

        [OperationContract]
        ServiceResponse eliminar(Int32 CodTipoParticipantes);

        [OperationContract]
        List<TipoParticipante> listar();

        [OperationContract]
        TipoParticipante buscar(Int32 CodTipoParticipantes);
    }
}
