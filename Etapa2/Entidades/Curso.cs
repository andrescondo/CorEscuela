using System;
using System.Collections.Generic;

namespace CorEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId {get; set;}

        public string Nombre {get; set;}

        public Jornadas jornada {get; set;} 

        public List<Asignatura> Asignatura {get; set;} 

         public List<Alumno> Alumno {get; set;}
         public List<Evaluaciones> Evaluaciones {get; set;}
        


        public Curso() => UniqueId = Guid.NewGuid().ToString();

    }
   
}