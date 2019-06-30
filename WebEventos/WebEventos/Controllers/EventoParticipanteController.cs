using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.Models;
using WebEventos.SRefEvento;
using WebEventos.SRefParticipante;
using WebEventos.SRefEventoParticipante;

namespace WebEventos.Controllers
{
    public class EventoParticipanteController : Controller
    {
        EventoServiceClient clientEv = new EventoServiceClient();
        ParticipanteServiceClient clientP = new ParticipanteServiceClient();

        // GET: EventoParticipante
        public ActionResult Index()
        {
            List<EventoParticipante> listEParticipante = new List<EventoParticipante>();
            return View(listEParticipante);
        }


        public ActionResult Create()
        {
            try
            {
                EventoParticipanteModel eParticipante = new EventoParticipanteModel();
                eParticipante.Participante = new Participante();
                eParticipante.Evento = new Evento();
                eParticipante.Participantes = clientP.listar().ToList();
                eParticipante.Eventos = clientEv.listar().ToList();

                return View(eParticipante);
            }
            catch (Exception ex)
            {

            return RedirectToAction("Index");
                //throw;
            }


        }

        [HttpPost]
        public ActionResult Create(EventoParticipanteModel eParticipante)
        {
            try
            {

            }
            catch (Exception ex)
            {

                //throw;
            }

            return View(eParticipante);

        }
    }
}