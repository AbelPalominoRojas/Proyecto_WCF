
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public Int32 CodUsuario { get; set; }

        [DataMember]
        [Required]
        public String Nombres { get; set; }

        [DataMember]
        [Required]
        public String Apellidos { get; set; }

        [DataMember]
        [Required]
        public String Email { get; set; }

        [DataMember]
        [Required]
        public String Password { get; set; }
        [DataMember]
        public String Estado { get; set; }

    }
}
