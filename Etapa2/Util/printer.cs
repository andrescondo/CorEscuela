using static System.Console;

namespace  CorEscuela.Util
{
    public static class Printer
    {
        public static object Writetitle { get; internal set; }

        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void DibujarTitle(string title)
        {
            var tamaño = title.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {title} |");
            DibujarLinea(tamaño);
        }

        public static void Beep(int hz=2000, int t = 500, int cant = 5)
        {
            while (cant-- > 0)
            {
                System.Console.Beep(hz, t);
            }
        }
        

    }
}