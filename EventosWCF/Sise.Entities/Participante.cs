
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class Participante
    {
        [DataMember]
        public Int32 CodParticipante { get; set; }

        [DataMember]
        [Required]
        public String Nombres { get; set; }

        [DataMember]
        [Required]
        public String Apellidos { get; set; }

        [DataMember]
        [Required]
        [StringLength(8)]
        public String Dni { get; set; }

        [DataMember]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaNac { get; set; }
        [DataMember]
        public String Direccion { get; set; }

        [DataMember]
        [Required]
        public String Correo { get; set; }
        [DataMember]
        public String Telefono { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public Int32 CodTipoParticipante { get; set; }

        [DataMember]
        public String Estado { get; set; }

        [DataMember]
        public TipoParticipante TipoParticipante { get; set; }

    }
}
