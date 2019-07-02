using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEventos.Util;

namespace WebEventos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session[Constantes.UsuarioSession]==null)
            {
                return RedirectToAction("Auth", "Login");
            }
            return View();
        }
    }
}