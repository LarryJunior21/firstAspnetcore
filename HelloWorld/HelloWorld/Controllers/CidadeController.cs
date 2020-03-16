using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult ObterEstados()
        {
            HelloWorld.CamadaNegocio.CidadeCamadaNegocio ccn = new CamadaNegocio.CidadeCamadaNegocio();

            return Json(
                ccn.ObterEstados()
            );
        }
    }
}