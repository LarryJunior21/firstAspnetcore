using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(string usuario, string senha)
        { 
            ViewBag.Usuario = usuario;
            ViewBag.Senha = senha;

            //ViewBag.Usuario = Request.Form["usuario"];
            //ViewBag.Senha= Request.Form["senha"];

            ViewBag.Msg = "Dados inválidos";
            return View("Index");
        }
    }
}