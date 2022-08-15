using System;
using System.Collections.Generic;


namespace escuela_aspnet_core_app.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }

    }
}