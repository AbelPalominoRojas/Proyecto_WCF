
using System;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class Participante
    {
        [DataMember]
        public Int32 CodParticipante { get; set; }
        [DataMember]
        public String Nombres { get; set; }
        [DataMember]
        public String Apellidos { get; set; }
        [DataMember]
        public String Dni { get; set; }
        [DataMember]
        public DateTime FechaNac { get; set; }
        [DataMember]
        public String Direccion { get; set; }
        [DataMember]
        public String Correo { get; set; }
        [DataMember]
        public String Telefono { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public Int32 CodTipoParticipante { get; set; }

    }
}
