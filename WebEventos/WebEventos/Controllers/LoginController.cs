using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.SRefUsuario;
using WebEventos.Util;

namespace WebEventos.Controllers
{
    public class LoginController : Controller
    {
        UsuarioServiceClient usClient = new UsuarioServiceClient();
        // GET: Login
        public ActionResult Auth()
        {
            if (Session[Constantes.UsuarioSession] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult Auth(Usuario usuario)
        {

            try
            {

                if (String.IsNullOrWhiteSpace(usuario.Email))
                {
                    ViewBag.message = "Ingrese su Email";
                    return View(usuario);
                }

                if (String.IsNullOrWhiteSpace(usuario.Password))
                {
                    ViewBag.message = "Ingrese su password ";

                    return View(usuario);
                }

                Usuario usulogeado = usClient.login(usuario.Email, usuario.Password);

                if (usulogeado != null)
                {
                    if (usulogeado.Email.Equals(usulogeado.Email))
                    {
                        Session[Constantes.UsuarioSession] = usulogeado;

                        return RedirectToAction("Index", "Home");
                    }
                }

                ViewBag.Message = "Su Email y/o Password es incorrecto";

            }
            catch (Exception ex)
            {

                ViewBag.Message = "Ha ocurrido un error!!!. Intentelo mas tarde";
            }

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Session.Remove(Constantes.UsuarioSession);

            return RedirectToAction("Auth", "Login");
        }


    }
}