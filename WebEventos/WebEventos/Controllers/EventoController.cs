using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.SRefEvento;
using WebEventos.SRefAreaTematica;

namespace WebEventos.Controllers
{
    public class EventoController : Controller
    {
        EventoServiceClient clientEv = new EventoServiceClient();
        AreaTematicaServiceClient clientAt = new AreaTematicaServiceClient();

        // GET: Evento
        public ActionResult Index()
        {
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
            try
            {
                Evento evento = clientEv.buscar(id);

                if (evento == null)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.areaTematicas = comboBoxAreaTematica();
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
            try
            {

                ViewBag.areaTematicas = comboBoxAreaTematica();

                return View(new Evento());
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
            try
            {
                evento.CodUsuario = 1;
                evento.LugaresDisponibles = evento.LimiteParticipantes;
                SRefEvento.ServiceResponse response = clientEv.registrar(evento);

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");

                }

                ViewBag.areaTematicas = comboBoxAreaTematica();

                ViewBag.Message = response.Message;

                return View(evento);

            }
            catch (Exception ex)
            {
                return View(evento);
            }
        }

        // GET: Evento/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Evento evento = clientEv.buscar(id);

                if (evento == null)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.areaTematicas = comboBoxAreaTematica();
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
            try
            {
                evento.CodEvento = id;
                evento.CodUsuario = 1;
                SRefEvento.ServiceResponse response = clientEv.actualizar(evento);

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");

                }


                ViewBag.areaTematicas = comboBoxAreaTematica();

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
            return View();
        }

        // POST: Evento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private IEnumerable<SelectListItem> comboBoxAreaTematica()
        {
            return (from at in clientAt.listar() select new SelectListItem() { Value = at.CodAreaTematica.ToString(), Text = at.NombreAreaTematica });
        }
    }
}
