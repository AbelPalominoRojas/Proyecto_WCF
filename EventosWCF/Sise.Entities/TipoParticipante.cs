
using System;
using System.Runtime.Serialization;

namespace Sise.Entities
{
    [DataContract]
    public class TipoParticipante
    {
        [DataMember]
        public Int32 CodTipoParticipante { get; set; }
        [DataMember]
        public String NombreTipoParticipante { get; set; }
        [DataMember]
        public String Estado { get; set; }

    }
}
