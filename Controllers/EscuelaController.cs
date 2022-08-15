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
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Lima";
            escuela.Pais = "Peru";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.Dirección = "Chorrillo, Lima";

            ViewBag.CosaDinamica = "La Monja";
            return View(escuela);
        }
    }
}

