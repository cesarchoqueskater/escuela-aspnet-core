using System;
using escuela_aspnet_core_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace escuela_aspnet_core_app.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoFundacion = 2005;
            escuela.EscuelaID = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";

            ViewBag.CosaDinamica = "La Monja";
            return View(escuela);
        }
    }
}

