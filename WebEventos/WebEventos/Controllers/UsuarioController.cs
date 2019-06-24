using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.SRefUsuario;

namespace WebEventos.Controllers
{
    public class UsuarioController : Controller
    {
        //Crear objeto de tipo WebService
        UsuarioServiceClient clienteu = new UsuarioServiceClient();

        // GET: Listado de Usuario 
        public ActionResult Index()
        {
            List<Usuario> lstu = new List<Usuario>();
            try
            {
                lstu = clienteu.listar().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }

            return View(lstu);
        }

        // GET: Usuario/Details/5 Ver un usuario por su id
        public ActionResult Details(int id)
        {
            Usuario usuario = clienteu.buscar(id);
            if (usuario == null)
            {
                return RedirectToAction("index");
            }
            return View(usuario);
        }

        // GET: Usuario/Create - Contruye un Nuevo Usuario
        public ActionResult Create()
        {
            return View(new Usuario());
        }

        // POST: Usuario/Create - Guarda todo un Usuario
        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                ServiceResponse response = clienteu.registrar(usuario);
                // TODO: Add insert logic here
                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                ViewBag.Message = response.Message;
                return View(usuario);
            }
            catch
            {
                return View(usuario);
            }
        }

        // GET: Usuario/Edit/5 Buscamos por el ID
        public ActionResult Edit(int id)
        {
            Usuario usuario = clienteu.buscar(id);
            if (usuario==null)
            {
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // POST: Usuario/Edit/5 Actualizamos un Usuario segun su ID
        [HttpPost]
        public ActionResult Edit(int id, Usuario usuario)
        {
            try{
                usuario.CodUsuario = id;
                ServiceResponse response = clienteu.actualizar(usuario);
                // TODO: Add update logic here
                if (response.IsSuccess) {
                    return RedirectToAction("Index");
                }
                ViewBag.Message = response.Message;
                return View(usuario);
            }catch{
                return View(usuario);
            }
        }

        // GET: Usuario/Delete/5 Buscar registro a eliminar
        public ActionResult Delete(int id)
        {
            Usuario usuario = clienteu.buscar(id);
            if (usuario == null)
            {
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // POST: Usuario/Delete/ Cambia el estado por E segun su ID
        [HttpPost]
        public ActionResult Delete(int id, Usuario usuario)
        {
            try
            {
                ServiceResponse response = clienteu.eliminar(id);
                // TODO: Add delete logic here

                if (response.IsSuccess)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.Message = response.Message;
                return View(usuario);
            }
            catch
            {
                return View(usuario);
            }
        }
    }
}
