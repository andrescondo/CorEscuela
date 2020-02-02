namespace CorEscuela.Entidades 
{
    class Escuela
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

        public Escuela(string nombre, int año) => (Nombre, añoDeCreación) = (nombre, año);

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TiposEscuelas}\n País: {país}, Ciudad: {ciudad}";
        }

    }

}