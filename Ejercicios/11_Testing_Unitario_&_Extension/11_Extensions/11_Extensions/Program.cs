using Entidades;

namespace _11_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio_I01();
            Ejercicio_I02();
        }
        public static void Ejercicio_I01()
        {
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(EEstaciones.Invierno));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(EEstaciones.Primavera));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(EEstaciones.Verano));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronicaTV(EEstaciones.Otonio));
        }
        public static void Ejercicio_I02()
        {
            while(true)
            {
                Console.Write("Ingrese un numero: ");
                string? response = Console.ReadLine();
                long.TryParse(response, out long numero);
                Console.WriteLine("Numero de {0,10} dígitos", numero.ContarCantidadDeDigitos());
            }
        }
    }
}