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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAuditoria_Paticipante_por_UsuarioService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAuditoria_Paticipante_por_UsuarioService
    {
        [OperationContract]
        ServiceResponse registrar(Auditoria_Paticipante_por_Usuario auditoriaparticipanteporusuario);

    }
}
