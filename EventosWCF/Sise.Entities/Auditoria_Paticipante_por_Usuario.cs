using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class Auditoria_Paticipante_por_Usuario
    {
        [DataMember]
        public Int32 CodAuditoriaPart_User { get; set; }

        [DataMember]
        public String Email_usuario { get; set;}

        [DataMember]
        public Int32 CodParticipante { get; set; }

        [DataMember]
        public DateTime Fecha { get; set; }

        [DataMember]
        public String Accion { get; set; }
    }
}
