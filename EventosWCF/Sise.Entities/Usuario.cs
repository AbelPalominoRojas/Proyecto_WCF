
using System;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public Int32 CodUsuario { get; set; }
        [DataMember]
        public String Nombres { get; set; }
        [DataMember]
        public String Apellidos { get; set; }
        [DataMember]
        public String Email { get; set; }
        [DataMember]
        public String Password { get; set; }
        [DataMember]
        public String Estado { get; set; }

    }
}
