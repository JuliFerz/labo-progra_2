using Metodos;

namespace Clase_01
{
    internal class Clase_01
    {
        static void Ejercicio_l01()
        {
            Console.Title = "Ejercicio l01";
            int numero;
            int min = 0;
            int max = 0;
            int suma = 0;
            int promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                int.TryParse(Console.ReadLine(), out numero);
                suma += numero;
            }
            Console.WriteLine($"La suma es: {suma}");
        }
        /*static void Ejercicio_01()
        {
            Console.Title = "Ejercicio 01";
            int numero;
            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                int.TryParse(Console.ReadLine(), out numero);
                suma += numero;
            }
            Console.WriteLine($"La suma es: {suma}");
        }*/
        

        static void Main(string[] args)
        {
            // New exercises
            //Ejercicio_l01();

            // Old exercises
            //Ejercicios.Ejercicio_01();
            //Ejercicios.Ejercicio_02();
            //Ejercicios.Ejercicio_03();
            //Ejercicios.Ejercicio_04();
            //Ejercicios.Ejercicio_06();
            //Ejercicios.Ejercicio_07();
            //Ejercicios.Ejercicio_09();
            Ejercicios.Ejercicio_10();

        }
    }
}