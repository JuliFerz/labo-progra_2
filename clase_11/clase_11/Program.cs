using Entidades.MetodoDeExtension;
using Entidades.Modelo;

namespace clase_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            Conversor c = new Conversor();

            // NO USAR ASI
            //Console.Write(MisMetodosDeExtension.CantidadDeLetras("TEST"));

            Console.WriteLine(numero.ElevarAlCuadrado());
            Console.WriteLine("Hello, World!".CantidadDeLetras());

            Console.WriteLine(c.ExtenderConversor());

            Console.WriteLine("Hola".Concatenar(" Mundo!").Concatenar(" Como"," Estas"));
        }
    }
}