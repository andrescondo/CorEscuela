using System;
using CorEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("El nuevo milenio", 2020, TiposEscuelas.Primaria, 
                                     ciudad:"Guayaquil", país:"Ecuador"
            ); /*los objetos opcionales son presindibles, 
            no importa si no son llamados, o, otro puesto en su posicion, no son afectados*/ 

            Curso[] arregloCurso = 
            {
                Curso(){Nombre="101"},
                Curso(){Nombre="201"},
                Curso(){Nombre="301"}
            } 
           
            Console.WriteLine(escuela);
            System.Console.WriteLine("======================================");
            ImprimirCursosforEach(arregloCurso);

        }

        private static void ImprimirCursosforEach(Curso[] arregloCurso)
        {
            foreach (var curso in arregloCurso)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, ID {curso.UniqueId}");
            }
            
        }
    }
}
