using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.SRefParticipante;
using WebEventos.SRefTipoParticipante;
using WebEventos.Util;


namespace WebEventos.Controllers
{
    public class ParticipanteController : Controller
    {
        ParticipanteServiceClient clientP = new ParticipanteServiceClient();
        TipoParticipanteServiceClient clientTp = new TipoParticipanteServiceClient();

        // GET: Participante
        public ActionResult Index()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
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
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            Participante participante = clientP.buscar(id);

            if (participante==null)
            {
                return RedirectToAction("Index");
            }
            return View(participante);
        }

        // GET: Participante/Create
        public ActionResult Create()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {

                ViewBag.TipoParticipantes = comboBoxTipoParticipante();

                return View(new Participante() { FechaNac = DateTime.Now});
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
                SRefParticipante.ServiceResponse response = clientP.registrar(participante);

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");
                }


                ViewBag.TipoParticipantes = comboBoxTipoParticipante();

                ViewBag.Message = response.Message;
                //return View(participante);

            }
            catch (Exception ex)
            {
            }
            return View(participante);
        }



        // GET: Participante/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            try
            {
                Participante participante = clientP.buscar(id);
                if (participante == null)
                {
                    return RedirectToAction("Index");
                }
                ViewBag.TipoParticipantes = comboBoxTipoParticipante();

                return View(participante);
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
                // throw;
            }
           
        }

        // POST: Participante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Participante participante)
        {
           
            try
            {
                participante.CodParticipante = id;
                SRefParticipante.ServiceResponse response = clientP.actualizar(participante);
                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.TipoParticipantes = comboBoxTipoParticipante();

                ViewBag.Message = response.Message;
            }
            catch (Exception ex)
            {
              
            }
            return View(participante);
        }

        // GET: Participante/Delete/5
        public ActionResult Delete(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            Participante participante = clientP.buscar(id);
            if (participante==null)
            {
                return RedirectToAction("Index");
            }
            return View(participante);
        }

        // POST: Participante/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Participante participante)
        {
           
            try
            {
                SRefParticipante.ServiceResponse response = clientP.eliminar(id);

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                // TODO: Add delete logic here
                return View(participante);
              
            }
            catch
            {
                return View(participante);
            }
        }

        private IEnumerable<SelectListItem> comboBoxTipoParticipante()
        {
            return (from tp in clientTp.listar()
                    select
                  new SelectListItem() { Value = tp.CodTipoParticipante.ToString(), Text = tp.NombreTipoParticipante });
        }
    }
}
