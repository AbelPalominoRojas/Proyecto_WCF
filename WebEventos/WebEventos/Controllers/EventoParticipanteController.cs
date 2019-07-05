using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.Models;
using WebEventos.SRefEvento;
using WebEventos.SRefEventoParticipante;
using WebEventos.SRefUsuario;
using WebEventos.Util;

namespace WebEventos.Controllers
{
    public class EventoParticipanteController : Controller
    {
        EventoParticipanteServiceClient evpClient = new EventoParticipanteServiceClient();
        EventoServiceClient clientEv = new EventoServiceClient();

        // GET: EventoParticipante
        public ActionResult Index()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            //List<EventoParticipante> listEParticipante = new List<EventoParticipante>();
            //return View(listEParticipante);
            return View();
        }


        public ActionResult Create(int? id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {

                if (id == null)
                {
                    return RedirectToAction("Index");
                }    

                Evento evento = clientEv.buscar(id ?? 0);

                if (evento == null)
                {
                    return RedirectToAction("Index");
                }

                return View(evento);
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
                EventoParticipante respuestaEventoParticipante = evpClient.buscar(eParticipante.CodEvento,eParticipante.CodParticipante); 

                if(respuestaEventoParticipante != null)
                {
                    response.Message = "Participante ya se encuentra registrado en este Evento.";
                    return Json(response, JsonRequestBehavior.AllowGet);
                }

                Usuario usLogeado = (Usuario)Session[Constantes.UsuarioSession];
                eParticipante.CodUsuario = usLogeado.CodUsuario;
                response = evpClient.registrar(eParticipante);
            }
            catch (Exception ex)
            {
                response.Message = "Ha ocurrido un error inesperado, contacte al administrador del sistema.";
                //throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);

        }
    }
}