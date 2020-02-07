using System;
using CorEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using CorEscuela;
using CorEscuela.Util;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.inicializar();
      

            imprimirCursosEscuela(engine.Escuela);
        }

        
        private static bool Predicado (Curso curobj)
        {
            return curobj.Nombre == "301";
         }
        private static void imprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitle("Curso Escuela");
            Printer.Beep();

            if(escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, ID {curso.UniqueId}");
                }
            }
            

        }

    }
}
