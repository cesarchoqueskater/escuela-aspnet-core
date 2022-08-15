using System;
using escuela_aspnet_core_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace escuela_aspnet_core_app.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura()
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };

            ViewBag.CosaDinamica = "La Monja Asignatura";
            ViewBag.Fecha = DateTime.Now;

            return View(asignatura);
        }
    }
}

