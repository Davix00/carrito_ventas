using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            ViewBag.Message = "Vista para administrar a los usuarios.";

            return View();
        }

        [HttpGet]
        public JsonResult ListarUsuarios() 
        { 
            List<Usuario> oLista = new List<Usuario>();
            oLista = new CN_Usuarios().listar();

            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);
        }
    }
}