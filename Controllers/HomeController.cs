using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeSeneLauIII.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Nota()
        {

            return View();
        }

        public ActionResult CalculaNota(int Erros)
        {
            if (Erros == null || Erros > 10 || Erros < 0)
            {
                TempData["Nota"] = "Invalido";
                return RedirectToAction("Nota");
            }
            TempData["Nota"] = 10 - Erros;
            return View();
        }
    }
}