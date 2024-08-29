using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Categoria()
        {
            ViewBag.Message = "Vista para administrar las categorías.";

            return View();
        }

        public ActionResult Marca()
        {
            ViewBag.Meessage = "Vista para administrar las marcas";

            return View();
        }

        public ActionResult Producto()
        {
            ViewBag.Meessage = "Vista para administrar las marcas";

            return View();
        }
    }
}