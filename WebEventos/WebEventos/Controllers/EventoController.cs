using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.SRefEvento;
using WebEventos.SRefAreaTematica;
using WebEventos.Models;
using WebEventos.Util;
using WebEventos.SRefUsuario;

namespace WebEventos.Controllers
{
    public class EventoController : Controller
    {
        EventoServiceClient clientEv = new EventoServiceClient();
        AreaTematicaServiceClient clientAt = new AreaTematicaServiceClient();

        // GET: Evento
        public ActionResult Index()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            List<Evento> listEvento = new List<Evento>();

            try
            {
                listEvento = clientEv.listar().ToList();

            }
            catch (Exception ev)
            {

                //throw;
            }

            return View(listEvento);
        }

        // GET: Evento/Details/5
        public ActionResult Details(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {
                Evento evento = clientEv.buscar(id);

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

        // GET: Evento/Create
        public ActionResult Create()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {

                ViewBag.areaTematicas = comboBoxAreaTematica();

                return View(new Evento() { FechaEvento = DateTime.Now});
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
                //throw;
            }


        }



        // POST: Evento/Create
        [HttpPost]
        public ActionResult Create(Evento evento)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {

                Usuario usLogeado = (Usuario)Session[Constantes.UsuarioSession];

               
                if (evento==null)
                {
                    ViewBag.Message = "Ingrese Datos";
                    return View(evento);

                }

                evento.CodUsuario = usLogeado.CodUsuario;
                evento.LugaresDisponibles = evento.LimiteParticipantes;

                SRefEvento.ServiceResponse respuesta = clientEv.registrar(evento);

                if (respuesta.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
             

                ViewBag.Message = respuesta.Message;

                return View(evento);

            }
            catch (Exception ex)
            {
               
            }

            ViewBag.AreaTematicas = comboBoxAreaTematica();

            return View(evento);
        }

        // GET: Evento/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {
                Evento evento = clientEv.buscar(id);

                if (evento == null)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.areaTematicas = comboBoxAreaTematica();
                ViewBag.estados = comboBoxEstado();

                return View(evento);
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
                //throw;
            }

        }

        // POST: Evento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Evento evento)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {
                Usuario usLogeado = (Usuario)Session[Constantes.UsuarioSession];

                evento.CodEvento = id;
                evento.CodUsuario = usLogeado.CodUsuario;
                SRefEvento.ServiceResponse response = clientEv.actualizar(evento);

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");

                }


                ViewBag.areaTematicas = comboBoxAreaTematica();
                ViewBag.estados = comboBoxEstado();

                ViewBag.Message = response.Message;
            }
            catch (Exception ex)
            {
            }

            return View(evento);

        }

        // GET: Evento/Delete/5
        public ActionResult Delete(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {
                Evento evento = clientEv.buscar(id);

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

        // POST: Evento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Evento evento)
        {
           
            try
            {

                SRefEvento.ServiceResponse service = clientEv.eliminar(id);
                // TODO: Add delete logic here
                if (service.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(evento);
            }
            catch
            {
                return View(evento);
            }
        }

        private IEnumerable<SelectListItem> comboBoxAreaTematica()
        {
            return (from at in clientAt.listar() select new SelectListItem() { Value = at.CodAreaTematica.ToString(), Text = at.NombreAreaTematica });
        }

        private IEnumerable<SelectListItem> comboBoxEstado()
        {
            List<SelectListItem> estados = new List<SelectListItem>();

            estados.Add(new SelectListItem() { Value = "A", Text = "Activo" });
            estados.Add(new SelectListItem() { Value = "F", Text = "Finalizado" });
            estados.Add(new SelectListItem() { Value = "E", Text = "Cancelado" });


            return estados;
        }

        public String getEstado(String estado)
        {
            return comboBoxEstado().FirstOrDefault(e => e.Value == estado).Text;
        }

        public JsonResult searhList(EventoFiltro eventoFiltro)
        {
            List<Evento> listEvento = new List<Evento>();
            try
            {
                listEvento = clientEv.buscarLista(eventoFiltro.codAreaTematica, eventoFiltro.fechaDesde, eventoFiltro.fechaHasta).ToList();
            }
            catch (Exception ex)
            {

               // throw;
            }

            return Json(listEvento, JsonRequestBehavior.AllowGet);
        }
    }
}
