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

            var curso1 = new Curso()
            {
                Nombre="101"
            };
            var curso2 = new Curso()
            {
                Nombre="201"
            };

            var curso3 = new Curso()
            {
                Nombre="301"
            };

           
            Console.WriteLine(escuela);
            System.Console.WriteLine("======================================");
            System.Console.WriteLine(curso1.Nombre + " ," + curso1.UniqueId);
            System.Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
            System.Console.WriteLine($"{curso3.Nombre} , {curso3.UniqueId}");

        }
    }
}
