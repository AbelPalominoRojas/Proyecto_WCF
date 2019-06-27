
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class Evento
    {
        [DataMember]
        public Int32 CodEvento { get; set; }

        [DataMember]
        [Required]
        public Int32 CodAreaTematica { get; set; }

        [DataMember]
        [Required]
        public String NombreEvento { get; set; }
        [DataMember]
        public String DescripcionEvento { get; set; }

        [DataMember]
        [Required]
        public DateTime FechaEvento { get; set; }

        [DataMember]
        [Required]
        public String Expositor { get; set; }

        [DataMember]
        [Required]
        public String LugarEvento { get; set; }

        [DataMember]
        [Required]
        public Int32 LimiteParticipantes { get; set; }
        [DataMember]
        public Int32 LugaresDisponibles { get; set; }

        [DataMember]
        [Required]
        public Int32 CodUsuario { get; set; }
        [DataMember]
        public String Estado { get; set; }

    }
}
