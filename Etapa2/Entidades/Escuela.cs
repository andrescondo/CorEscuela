using System.Collections.Generic;
namespace CorEscuela.Entidades 
{
    public class Escuela
    {
        string nombre;
        public string Nombre
        {
            get{ return nombre;}
            set{nombre =value.ToUpper();}
        }

        public int añoDeCreación{get; set;}

        public string país { get; set; }

        public string ciudad { get; set; }

        public TiposEscuelas TiposEscuelas {get; set;}

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int año,
                        TiposEscuelas tipos,
                        string país="", //con el ="" le digo al sistema que el caracter aun no ha sido declarado
                        string ciudad=""
        )
        {
            (Nombre, añoDeCreación)= (nombre, año);
            this.país = país;
            this.ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TiposEscuelas} {System.Environment.NewLine} País: {país}, Ciudad: {ciudad}";
        } //{System.Environment.NewLine} es equivalente al \n, pero el primero sirve para cualquier sistemas

    }

}