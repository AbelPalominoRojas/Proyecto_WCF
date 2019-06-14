
using System;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class EventoParticipante
    {
        [DataMember]
        public Int32 CodEvento { get; set; }
        [DataMember]
        public Int32 CodParticipante { get; set; }
        [DataMember]
        public DateTime FechaRegistro { get; set; }
        [DataMember]
        public Boolean ParticipanteAsistio { get; set; }
        [DataMember]
        public Int32 CodUsuario { get; set; }
        [DataMember]
        public String Estado { get; set; }

    }
}
