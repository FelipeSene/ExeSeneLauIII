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
            Carro carro = new Carro();
            carro.Fabricante = "Chevrolet";
            carro.Chassis = "Coupe";
            carro.Nome = "Camaro";
            carro.Transmissao = "Automatica";

            Moto moto = new Moto();
            moto.Fabricante = "Ducati";
            moto.Chassis = "Sport";
            moto.Cilindrada = 1200;
            moto.Transmissao = "Manual";

            ViewData["CFabricante"] = carro.Fabricante;
            ViewData["CChassis"] = carro.Chassis;
            ViewData["CNome"] = carro.Nome;
            ViewData["CTransmissao"] = carro.Transmissao;

            ViewData["MFabricante"] = moto.Fabricante;
            ViewData["MChassis"] = moto.Chassis;
            ViewData["MCilindrada"] = moto.Cilindrada;
            ViewData["MTransmissao"] = moto.Transmissao;

            return View();
        }

        public ActionResult ConsultaCarro() 
       {
            Carro carro = new Carro();
            carro.Fabricante = "Chevrolet";
            carro.Chassis = "Coupe";
            carro.Nome = "Camaro";
            carro.Transmissao = "Automatica";
            return View(carro);
       }
    
        public ActionResult ConsultaMoto() 
        {
            Moto moto = new Moto();
            moto.Fabricante = "Ducati";
            moto.Chassis = "Sport";
            moto.Cilindrada = 1200;
            moto.Transmissao = "Manual";

            return View(moto);
        }
    }
}