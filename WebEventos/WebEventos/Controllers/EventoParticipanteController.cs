using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.Models;
using WebEventos.SRefEventoParticipante;
using WebEventos.Util;

namespace WebEventos.Controllers
{
    public class EventoParticipanteController : Controller
    {
        EventoParticipanteServiceClient evpClient = new EventoParticipanteServiceClient();

        // GET: EventoParticipante
        public ActionResult Index()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            List<EventoParticipante> listEParticipante = new List<EventoParticipante>();
            return View(listEParticipante);
        }


        public ActionResult Create()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {
                //EventoParticipanteModel eParticipante = new EventoParticipanteModel();
                //eParticipante.Participante = new Participante();
                //eParticipante.Evento = new Evento();
                //eParticipante.Participantes = clientP.listar().ToList();
                //eParticipante.Eventos = clientEv.listar().ToList();

                return View(new EventoParticipante());
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
                //throw;
            }


        }

        [HttpPost]
        public JsonResult Create(EventoParticipante eParticipante)
        {
            SRefEventoParticipante.ServiceResponse response = new SRefEventoParticipante.ServiceResponse();

            try
            {
                response = evpClient.registrar(eParticipante);
            }
            catch (Exception ex)
            {
                response.Message = "Ha ocurrido un error inesperado, contacte al administrador del sistema.";
                //throw;
            }

            return Json(eParticipante,JsonRequestBehavior.AllowGet);

        }
    }
}