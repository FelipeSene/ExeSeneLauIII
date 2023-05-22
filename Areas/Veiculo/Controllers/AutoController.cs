using ExeSeneLauIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace ExeSeneLauIII.Areas.Veiculo.Controllers
{
    public class AutoController : Controller
    {
        // GET: Veiculo/Auto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConsultaVeiculo()
        {

            return View();
        }
       public ActionResult ConsultaCarro() 
       {
        
            return View();
       }
    
        public ActionResult ConsultaMoto() 
        {
            Moto moto = new Moto();

            return View();
        }
    }
}