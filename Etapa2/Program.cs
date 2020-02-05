﻿using System;
using CorEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;

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


            escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre="101", jornada = Jornadas.mañana},//jornada = nombre de la clase
                new Curso(){Nombre="201", jornada = Jornadas.mañana},//Jornadas = nombre del archivo
                new Curso(){Nombre="301", jornada = Jornadas.mañana},
<<<<<<< HEAD
                new Curso(){Nombre="401", jornada = Jornadas.mañana},
                new Curso(){Nombre="501", jornada = Jornadas.mañana},
                new Curso(){Nombre="501", jornada = Jornadas.tarde}
=======
                new Curso(){Nombre="401", jornada = Jornadas.mañana}
>>>>>>> 545c7b5aee9510ba3c311061402ce0e52e59928b
            };

            escuela.Cursos.Add(new Curso {Nombre = "102", jornada = Jornadas.tarde} );
            escuela.Cursos.Add(new Curso {Nombre = "202", jornada = Jornadas.tarde} );

            

            var otraColeccion = new List<Curso>(){
                new Curso(){Nombre="103", jornada = Jornadas.noche},
                new Curso(){Nombre="203", jornada = Jornadas.noche},
                new Curso(){Nombre="303", jornada = Jornadas.noche},
                new Curso(){Nombre="403", jornada = Jornadas.noche}
            };
            //otraColeccion.Clear(); -- Borra el objeto en especifico
            //escuela.Cursos.AddRange(otraColeccion); -- Agrega un objeto con todas los atributos

            //escuela.Cursos.RemoveAll(Predicado); -- Borra un dato en especifico de un objeto
<<<<<<< HEAD
            escuela.Cursos.RemoveAll(delegate (Curso cur)
            { 
                return cur.Nombre == "301"; 
            } ); //-- Forma delegate

            escuela.Cursos.RemoveAll( (cur) => cur.Nombre == "501" && cur.jornada == Jornadas.mañana );
=======

>>>>>>> 545c7b5aee9510ba3c311061402ce0e52e59928b

            imprimirCursosEscuela(escuela);
        }

<<<<<<< HEAD
        /*private static bool Predicado (Curso curobj)
        {
            return curobj.Nombre == "301";
        }*/
=======
        private static bool Predicado (Curso curobj)
        {
            return curobj.Nombre == "301";
         }
>>>>>>> 545c7b5aee9510ba3c311061402ce0e52e59928b

        private static void imprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("============================");
            WriteLine("      Curso Escuela");
            WriteLine("============================");
            if(escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, ID {curso.UniqueId}");
                }
            }
            

        }

        /*private static void ImprimirCursosforEach(Curso[] arregloCurso)
        {
            foreach (var curso in arregloCurso)
            {
                WriteLine($"Nombre {curso.Nombre}, ID {curso.UniqueId}");
            }
            
        }*/
    }
}
