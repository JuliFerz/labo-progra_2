namespace Ejercicios
{
    public class Ej
    {
        public static void Ejercicio_11()
        {
            const int limiteMin = -100;
            const int limiteMax = 100;
            const int cantidad = 10;
            int suma = 0;
            int maximo = 0;
            int minimo = 0;
            int numero;
            float promedio;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese un numero entero: ");
                int.TryParse(Console.ReadLine(), out numero);
                while (!Validacion.Validar(numero, limiteMin, limiteMax))
                {
                    Console.WriteLine("[ERROR] Vuelva a escribir el numero: ");
                    int.TryParse(Console.ReadLine(), out numero);
                }
                if (numero > maximo) { maximo = numero; }
                else if (numero < minimo) { minimo = numero; }

                suma += numero;
            }
            promedio = (float)suma / cantidad;
            Console.WriteLine($"•Valor mínimo: {minimo}\n•Valor máximo: {maximo}\n•Promedio: {promedio}\n");
        }
        public static void Ejercicio_12()
        {
            char salida;
            int suma = 0;
            int numero;

            for (; ; )
            {
                Console.WriteLine("Ingrese un numero entero: ");
                int.TryParse(Console.ReadLine(), out numero);
                suma += numero;

                Console.WriteLine("Desea continuar? (S/N)");
                char.TryParse(Console.ReadLine(), out salida);
                while (!Validacion.ValidaS_N(salida))
                {
                    Console.WriteLine("[ERROR] Desea continuar? (Elegir entre 'S', 'N')");
                    char.TryParse(Console.ReadLine(), out salida);
                }
                salida = char.ToUpper(salida);

                if (salida == 'N') { break; }
            }
            Console.WriteLine($"• La suma es: {suma}");
        }


        public class Validacion
        {
            public static bool Validar(int valor, int min, int max)
            {
                return valor >= min && valor <= max ? true : false;
            }

            public static bool ValidaS_N(char c)
            {
                c = char.ToUpper(c);
                return c == 'S' || c == 'N' ? true : false;
            }
        }

        /*public class Conversor
        {
            public static string DecimalBinario()
            {

            }
        }*/
    }
}