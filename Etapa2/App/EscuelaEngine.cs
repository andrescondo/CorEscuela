using System.Collections.Generic;
using CorEscuela.Entidades;

namespace CorEscuela
{
    public class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela)
        {
            this.Escuela = escuela;

        }
        public Escuela Escuela { get; set; }


        public EscuelaEngine()
        {

        }

        public void inicializar()
        {
            Escuela = new Escuela("El nuevo milenio", 2020, TiposEscuelas.Primaria,
                                     ciudad: "Guayaquil", país: "Ecuador"
                                     );
            
            cargarCurso();
            cargarAsignaturas();
            cargarAlumnos();
            
            cargarEvaluaciones();
        }

        private void cargarAlumnos()
        {
            string[] name1 = {"Alba", "Felipa", "Eunesio", "Farid", "Donald", "Alvaro", "Nicolas"};
            string[] name2 = { "freddy", "Anabel", "Luis", "Rick", "Morti", "Silvana", "Diomedes", "Teseo" };
            string[] lastname = { "Riuz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera"}
        }

        
        private void cargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignatura = new List<Asignatura>()
                {
                    new Asignatura{Nombre = "Matemáticas"},
                    new Asignatura{Nombre = "Educación Física"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"},
                    new Asignatura{Nombre = "Informática"}
                }

                curso.Asignatura.AddRange(listaAsignatura);
            }
        }

        
        private void cargarEvaluaciones()
        {

        }

        private void cargarCurso()
        {
            Escuela.Cursos = new List<Curso>(){
            new Curso(){Nombre="101", jornada = Jornadas.mañana},
            new Curso(){Nombre="201", jornada = Jornadas.mañana},
            new Curso(){Nombre="301", jornada = Jornadas.mañana},
            new Curso(){Nombre="401", jornada = Jornadas.mañana},
            new Curso(){Nombre="501", jornada = Jornadas.mañana},
            new Curso(){Nombre="501", jornada = Jornadas.tarde},
            new Curso(){Nombre="401", jornada = Jornadas.mañana},
            new Curso(){Nombre="103", jornada = Jornadas.noche},
            new Curso(){Nombre="203", jornada = Jornadas.noche},
            new Curso(){Nombre="303", jornada = Jornadas.noche},
            };
        }


    }
}