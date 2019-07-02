using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.SRefAreaTematica;
using WebEventos.Util;

namespace WebEventos.Controllers
{
    public class AreaTematicaController : Controller
    {
        AreaTematicaServiceClient client = new AreaTematicaServiceClient();

        // GET: Evento
        public ActionResult Index()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }

            List<AreaTematica> listAreaTematica = new List<AreaTematica>();
            try
            {
                listAreaTematica = client.listar().ToList();

            }
            catch (Exception ex)
            {

                //throw;
            }

            return View(listAreaTematica);
        }

        // GET: Evento/Details/5
        public ActionResult Details(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }


            AreaTematica areaTematica = client.buscar(id);

            if (areaTematica == null)
            {
                return RedirectToAction("Index");
            }

            return View(areaTematica);
        }

        // GET: Evento/Create
        public ActionResult Create()
        {
            return View(new AreaTematica());
        }

        // POST: Evento/Create
        [HttpPost]
        public ActionResult Create(AreaTematica areaTematica)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {
                ServiceResponse response = client.registrar(areaTematica);

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");

                }

                ViewBag.Message = response.Message;

                return View(areaTematica);

            }
            catch (Exception ex)
            {
                return View(areaTematica);
            }
        }

        // GET: Evento/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            AreaTematica areaTematica = client.buscar(id);

            if (areaTematica == null)
            {
                return RedirectToAction("Index");
            }

            return View(areaTematica);
        }

        // POST: Evento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AreaTematica areaTematica)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {
                areaTematica.CodAreaTematica = id;

                ServiceResponse response = client.actualizar(areaTematica);

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");

                }

                ViewBag.Message = response.Message;
                return View(areaTematica);

            }
            catch (Exception ex)
            {
                return View(areaTematica);
            }
        }

        // GET: Evento/Delete/5
        public ActionResult Delete(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }

            AreaTematica areaTematica = client.buscar(id);

            if (areaTematica == null)
            {
                return RedirectToAction("Index");
            }

            return View(areaTematica);
        }

        // POST: Evento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, AreaTematica areaTematica)
        {

            try
            {

                ServiceResponse response = client.eliminar(id);

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");

                }

                return View(areaTematica);

            }
            catch (Exception)
            {
                return View(areaTematica);
            }
        }


        public JsonResult lista()
        {
            List<AreaTematica> listAreaTematica = new List<AreaTematica>();
            try
            {
                listAreaTematica = client.listar().ToList();

            }
            catch (Exception ex)
            {

                //throw;
            }

            return Json(listAreaTematica, JsonRequestBehavior.AllowGet);
        }
    }
}
