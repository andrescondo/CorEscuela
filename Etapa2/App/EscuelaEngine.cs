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

            cargarAlumno();
            cargarAsignaturas();
            cargarEvaluaciones();
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