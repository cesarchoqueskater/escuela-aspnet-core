using System;
using System.Linq;
using escuela_aspnet_core_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace escuela_aspnet_core_app.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now;

            return View(new Alumno
            {
                Nombre = "Cesar",
                UniqueId = Guid.NewGuid().ToString()
            });
        }


        public IActionResult MultiAlumno()
        {
            var listaAlumno = GenerarAlumnosAlAzar();


            return View("MultiAlumno", listaAlumno);
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" ,
                                                  UniqueId = Guid.NewGuid().ToString()};

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}

