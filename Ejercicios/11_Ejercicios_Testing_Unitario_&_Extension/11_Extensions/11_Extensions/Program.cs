using Entidades;

namespace _11_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(EEstaciones.Invierno));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(EEstaciones.Primavera));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(EEstaciones.Verano));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(EEstaciones.Otonio));
        }
    }
}