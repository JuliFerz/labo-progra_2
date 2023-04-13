using Entidades;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            string resultado;

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            boligrafoAzul.Pintar(59, out resultado);

            Console.WriteLine(resultado);

        }
    }
}