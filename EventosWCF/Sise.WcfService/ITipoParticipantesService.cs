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
    public interface ITipoParticipantesService
    {
        [OperationContract]
        Response<TipoParticipante> registrar(TipoParticipante tipoParticipantes);

        [OperationContract]
        Response<TipoParticipante> actualizar(TipoParticipante tipoParticipantes);

        [OperationContract]
        Response<TipoParticipante> eliminar(Int32 CodTipoParticipantes);

        [OperationContract]
        Response<TipoParticipante> listar();

        [OperationContract]
        Response<TipoParticipante> buscar(Int32 CodTipoParticipantes);
    }
}
