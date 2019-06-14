
using System;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class Evento
    {
        [DataMember]
        public Int32 CodEvento { get; set; }
        [DataMember]
        public Int32 CodAreaTematica { get; set; }
        [DataMember]
        public String NombreEvento { get; set; }
        [DataMember]
        public String DescripcionEvento { get; set; }
        [DataMember]
        public DateTime FechaEvento { get; set; }
        [DataMember]
        public String Expositor { get; set; }
        [DataMember]
        public String LugarEvento { get; set; }
        [DataMember]
        public Int32 LimiteParticipantes { get; set; }
        [DataMember]
        public Int32 LugaresDisponibles { get; set; }
        [DataMember]
        public Int32 CodUsuario { get; set; }
        [DataMember]
        public String Estado { get; set; }

    }
}
