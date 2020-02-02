using System;

namespace CorEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId {get; set;}

        public string Nombre {get; set;}

        public Jornadas jornada {get; set;} 

        public Curso() => UniqueId = Guid.NewGuid().ToString();

    }
   
}