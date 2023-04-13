using Billetes;

namespace Ejercicio_l02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pesos peso = 398; // uso la funcion implicita
            Dolar dolar = (Dolar)peso;
            Console.WriteLine(dolar.GetCantidad());

        }
    }
}