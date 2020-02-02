namespace CorEscuela.Entidades 
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get{ return "Nombre: " + nombre;}
            set{nombre =value.ToUpper();}
        }

        public int añoDeCreación{get; set;}

        public string país { get; set; }

        public string ciudad { get; set; }

        /*public Escuela(string nombre, int año) => ()
        {
            this.nombre = nombre;
            añoDeCreación = año;
        }*/

        public Escuela(string nombre, int año) => (Nombre, añoDeCreación) = (nombre, año);

    }

}