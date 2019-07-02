using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEventos.Models
{
    public class EventoFiltro
    {
        public Int32 codAreaTematica { get; set; }
        public DateTime? fechaDesde { get; set; }
        public DateTime? fechaHasta { get; set; }
    }
}