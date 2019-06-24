using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.SRefParticipante;
using WebEventos.SRefTipoParticipante;

namespace WebEventos.Controllers
{
    public class ParticipanteController : Controller
    {
        ParticipanteServiceClient clientP = new ParticipanteServiceClient();
        TipoParticipanteServiceClient clientTp = new TipoParticipanteServiceClient();

        // GET: Participante
        public ActionResult Index()
        {
            List<Participante> listParticipantes = new List<Participante>();
            
            try
            {
                listParticipantes = clientP.listar().ToList();

                return View(listParticipantes);
            }
            catch (Exception ex)
            {

                return View(listParticipantes);
                //throw;
            }

        }

        // GET: Participante/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Participante/Create
        public ActionResult Create()
        {
            try
            {
                List<SelectListItem> tipoParticipantes = (from tp in clientTp.listar().ToList() select 
                                                          new SelectListItem() { Value = tp.CodTipoParticipante.ToString(), Text = tp.NombreTipoParticipante }).ToList();
                ViewBag.TipoParticipantes = tipoParticipantes;

                return View(new Participante());
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
                //throw;
            }

            
        }

        // POST: Participante/Create
        [HttpPost]
        public ActionResult Create(Participante participante)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Participante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Participante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Participante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Participante/Delete/5
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
    }
}
