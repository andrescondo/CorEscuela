using System;
using CorEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("El Universitaro", 2020);
            escuela.país = "Ecuador";
            escuela.ciudad = "Guayaquil";
            escuela.TiposEscuelas = TiposEscuelas.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
