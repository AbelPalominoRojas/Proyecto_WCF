using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.SRefTipoParticipante;
using WebEventos.Util;
namespace WebEventos.Controllers
{
    public class TipoParticipanteController : Controller
    {
        TipoParticipanteServiceClient clientTp = new TipoParticipanteServiceClient();

        // GET: TipoParticipante obteniendo el listado de Tipo Participante
        public ActionResult Index()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            List<TipoParticipante> listtp = new List<TipoParticipante>();
            try
            {
                listtp = clientTp.listar().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return View(listtp);
        }

        // GET: TipoParticipante/Details/5
        public ActionResult Details(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            TipoParticipante tipoparticipante = clientTp.buscar(id);
            if (tipoparticipante==null)
            {
                return RedirectToAction("index");
            }
            return View(tipoparticipante);
        }

        // GET: TipoParticipante/Create
        public ActionResult Create()
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            return View(new TipoParticipante());
        }

        // POST: TipoParticipante/Crear nuevo registro
        [HttpPost]
        public ActionResult Create(TipoParticipante tipoparticipante)
        {
          
            try
            {
                ServiceResponse response = clientTp.registrar(tipoparticipante);
                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                ViewBag.Message = response.Message;
                return View(tipoparticipante);
            }
            catch
            {
                return View(tipoparticipante);
            }
        }

        // GET: TipoParticipante/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            TipoParticipante tipoparticipante = clientTp.buscar(id);
            if (tipoparticipante==null)
            {
                return RedirectToAction("Index");
            }
            return View(tipoparticipante);
        }

        // POST: TipoParticipante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TipoParticipante tipoparticipante)
        {
           
            try
            {
                tipoparticipante.CodTipoParticipante = id;
                ServiceResponse response = clientTp.actualizar(tipoparticipante);
                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                ViewBag.Message = response.Message;
                return View(tipoparticipante);
            }
            catch(Exception ex)
            {
                return View(tipoparticipante);
            }
        }

        // GET: TipoParticipante/Delete/5
        public ActionResult Delete(int id)
        {
            if (Session[Constantes.UsuarioSession] == null)
            {
                return RedirectToAction("Auth", "Login");
            }
            TipoParticipante tipoparticipante = clientTp.buscar(id);
            if (tipoparticipante == null)
            {
                return RedirectToAction("index");
            }
            return View(tipoparticipante);
        }

        // POST: TipoParticipante/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TipoParticipante tipoparticipante)
        {
            try
            {
                ServiceResponse response = clientTp.eliminar(id);
                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.Message = response.Message;
                return View(tipoparticipante);
                
            }
            catch
            {
                return View(tipoparticipante);
            }
        }
    }
}
