using ExeSeneLauIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeSeneLauIII.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }
        [HttpPost]
        public ActionResult GetFuncionario(int Codigo, string Nome, string Funcao)
        {
                ViewBag.Codigo = Codigo;
                ViewBag.Nome = Nome;
                ViewBag.Funcao = Funcao;
            //if (Codigo == null || Codigo == 0 || Nome == "" || Funcao == "") {
            //    return RedirectToAction("CadastroFuncionario");
            //}

            if (ViewBag.Codigo == 0 || ViewBag.Codigo == null)
            {
                TempData["Input"] = "Código";
            }
            else if (ViewBag.Nome == "")
                TempData["Input"] = "Nome";
            else if (ViewBag.Funcao == "")
                TempData["Input"] = "Função";
            if (TempData["Input"] != null)
                return RedirectToAction("CadastroFuncionario");
            else
                return View();
        }
    }
}