
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class AreaTematica
    {
        [DataMember]
        public Int32 CodAreaTematica { get; set; }

        [DataMember]
        [Required]
        public String NombreAreaTematica { get; set; }
        [DataMember]
        public String Estado { get; set; }

    }
}
