using Entidades;
using Billetes;
using Temperaturas;

namespace _04_Ejercicios_sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio_19();
            Ejercicio_20();
            //Ejercicio_21();
        }

        public static void Ejercicio_19()
        {
            Sumador s1 = new Sumador(2);
            Sumador s2 = new Sumador(3);

            Console.WriteLine(s1.Sumar("Test", "string!")); // output: "Test string!"
            Console.WriteLine(s2.Sumar((int)s1, 6)); // 9 (it's 9 because s1 calls Sumar method previous to this,
                                                     // then "cantidadSumas" added 1 value to s1 (2 + 1) )
            Console.WriteLine((int)s1); // 2 (explicit conversion)
            Console.WriteLine((int)s2); // 3
            Console.WriteLine(s1 + s2); // 5
            Console.WriteLine(s1 | s2); // false (actually it's == comparison)
        }

        public static void Ejercicio_20()
        {
            Pesos peso = new Pesos(1);
            Dolar dolar = new Dolar(1);
            Euro euro = new Euro(1);
            Console.WriteLine(">> Peso");
            Console.WriteLine($"peso: {peso.GetCantidad()}"); // peso
            Console.WriteLine($"peso a dolar: {((Dolar)peso).GetCantidad()}"); // peso a dolar
            Console.WriteLine($"peso a euro: {((Euro)peso).GetCantidad()}"); // peso a euro

            Console.WriteLine("\n>> Dolar");
            Console.WriteLine($"dolar: {dolar.GetCantidad()}"); // dolar
            Console.WriteLine($"dolar a peso: {((Pesos)dolar).GetCantidad()}"); // dolar a peso
            Console.WriteLine($"dolar a euro: {((Euro)dolar).GetCantidad()}"); // dolar a euro

            Console.WriteLine("\n>> Euro");
            Console.WriteLine($"euro: {euro.GetCantidad()}"); // euro
            Console.WriteLine($"euro a dolar: {((Dolar)euro).GetCantidad()}"); // euro a dolar
            Console.WriteLine($"euro a peso: {((Pesos)euro).GetCantidad()}"); // euro a peso

            // =
            Dolar dolar2 = new Dolar(0.0045409383);
            Euro euro2 = new Euro(23);
            Pesos peso2 = new Pesos(1);
            Pesos peso3 = new Pesos(220.226);

            Console.WriteLine("\n== & !=");
            Console.WriteLine(" >> Peso");
            Console.WriteLine(peso == dolar); // false
            Console.WriteLine(peso == dolar2); // true
            Console.WriteLine(peso == euro); // false
            Console.WriteLine(peso != peso2); // false
            Console.WriteLine(peso != peso3); // true

            Console.WriteLine("\n>> Dolar");
            Console.WriteLine(dolar == dolar2); // false
            Console.WriteLine(dolar == euro); // true
            Console.WriteLine(dolar == peso3); // true

            Console.WriteLine("\n>> Euro");
            Console.WriteLine(euro == dolar2); // false
            Console.WriteLine(euro == euro2); // false
            Console.WriteLine(euro == peso); // false
            Console.WriteLine(euro != euro2); // true

            // +
            Pesos resultadoSuma = peso2 + dolar;
            Console.WriteLine(resultadoSuma.GetCantidad()); // 221,226

            // -
            Euro resultadoResta = euro2 - peso3;
            Console.WriteLine(resultadoResta.GetCantidad()); // 22,09


        }

        public static void Ejercicio_21()
        {
            Celsius c = new Celsius(20);
            Fahrenheit f = new Fahrenheit(70);
            Kelvin k = new Kelvin(280);

            Console.WriteLine(">> Celsius");
            Console.WriteLine(c.GetTemperatura());
            Console.WriteLine(((Fahrenheit)c).GetTemperatura()); // celsius a fahrenheit
            Console.WriteLine(((Kelvin)c).GetTemperatura()); // celsius a kelvin

            Console.WriteLine("\n>> Fahrenheit");
            Console.WriteLine(f.GetTemperatura());
            Console.WriteLine(((Celsius)f).GetTemperatura()); // fahrenheit a celsius
            Console.WriteLine(((Kelvin)f).GetTemperatura()); // fahrenheit a kelvin

            Console.WriteLine("\n>> Kelvin");
            Console.WriteLine(k.GetTemperatura());
            Console.WriteLine(((Celsius)k).GetTemperatura()); // kelvin a celsius
            Console.WriteLine(((Fahrenheit)k).GetTemperatura()); // kelvin a fahrenheit

            // =
            Kelvin k2 = new Kelvin(293.15);
            Fahrenheit f2 = new Fahrenheit(70);
            Celsius c2 = new Celsius(20);
            Celsius c3 = new Celsius(40);

            Console.WriteLine("\n== & !=");
            Console.WriteLine(">> Celsius");
            Console.WriteLine(c == k); // false
            Console.WriteLine(c == k2); // true
            Console.WriteLine(c == f); // false
            Console.WriteLine(c != c2); // false
            Console.WriteLine(c != c3); // true

            Console.WriteLine("\n>> Fahrenheit");
            Console.WriteLine(f == f2); // true
            Console.WriteLine(f == k); // false
            Console.WriteLine(f == c3); // false

            Console.WriteLine("\n>> Euro");
            Console.WriteLine(k == c2); // false
            Console.WriteLine(k == c3); // false
            Console.WriteLine(k == f2); // false
            Console.WriteLine(k != k2); // true

            // +
            Console.WriteLine("\n>> Sumas");
            Celsius resultadoSuma = c + k;
            Console.WriteLine(resultadoSuma.GetTemperatura()); // 26,850000000000023

            // -
            Console.WriteLine("\n>> Restas");
            Fahrenheit resultadoResta = f2 - k2;
            Console.WriteLine(resultadoResta.GetTemperatura()); // 2,000000000000057
        }
    }
}