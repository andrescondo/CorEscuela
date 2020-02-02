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

            escuela.país = "Ecuador";
            escuela.ciudad = "Guayaquil";
            escuela.TiposEscuelas = TiposEscuelas.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
