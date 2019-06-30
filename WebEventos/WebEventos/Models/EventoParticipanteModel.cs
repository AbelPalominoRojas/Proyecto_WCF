using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebEventos.SRefParticipante;
using WebEventos.SRefEvento;
using WebEventos.SRefEventoParticipante;

namespace WebEventos.Models
{
    public class EventoParticipanteModel
    {
        public Participante Participante { get; set; }
        public Evento Evento { get; set; }
        public EventoParticipante EventoParticipante { get; set; }
        public List<Participante> Participantes { get; set; }
        public List<Evento> Eventos { get; set; }
    }
}