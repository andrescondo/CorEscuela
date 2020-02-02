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

            var arregloCurso = new Curso[3];   
            
            arregloCurso[0] = new Curso()
                                {
                                    Nombre="101"
                                };

            var curso2 = new Curso()
            {
                Nombre="201"
            };
            arregloCurso[1] = curso2;

            arregloCurso[2] = new Curso()
                                {
                                    Nombre="301"
                                };

           
            Console.WriteLine(escuela);
            System.Console.WriteLine("======================================");
            ImprimirCursos(arregloCurso);

        }

        private static void ImprimirCursos(Curso[] arregloCurso)
        {
            int cont = 0;
            while (cont < arregloCurso.Length)
            {
                Console.WriteLine($"Nombre {arregloCurso[cont].Nombre}, ID {arregloCurso[cont].UniqueId}");
                cont++;
            }
        }
    }
}
