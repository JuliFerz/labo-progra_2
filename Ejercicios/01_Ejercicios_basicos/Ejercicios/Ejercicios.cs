namespace Ejercicios
{
    public class Ej
    {
        public static void Ejercicio_01()
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
        }
        public static void Ejercicio_02()
        {
            Console.Title = "Ejercicio 02";

            int numero;

            Console.WriteLine("Ingrese un numero:");
            int.TryParse(Console.ReadLine(), out numero);

            while (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
                int.TryParse(Console.ReadLine(), out numero);
            }
            Console.WriteLine($"{numero}^2 = {Math.Pow(numero, 2)}");
        }
        public static void Ejercicio_04()
        {
            Console.Title = "Ejercicio 04";

            int[] perfectNumbers = new int[4];
            int count = 0;

            for (int i = 1; count < 4; i++)
            {
                int sum = 0;
                for (int x = 1; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        sum += x;
                    }
                    if (x == i - 1 && sum == i)
                    {
                        perfectNumbers[count] = i;
                        count++;
                    }
                }
            }
            Console.WriteLine("Los numeros perfectos son:");
            foreach (int i in perfectNumbers)
            {
                Console.WriteLine("• {0}", i);
            }
        }
        public static void Ejercicio_06()
        {
            Console.Title = "Ejercicio 06";

            int fromYear;
            int toYear;
            bool hasLeapYears = false;

            Console.WriteLine("Año desde:");
            int.TryParse(Console.ReadLine(), out fromYear);

            Console.WriteLine("Año fin:");
            int.TryParse(Console.ReadLine(), out toYear);

            int i = fromYear;
            while (toYear > i)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine($"• Año biciesto: {i}");
                    hasLeapYears = true;
                }
                i++;
            }

            if (!hasLeapYears)
            {
                Console.WriteLine($"No se encontraron años entre {fromYear} y {toYear}");
            }

        }
        public static void Ejercicio_07()
        {
            Console.Title = "Ejercicio 07";

            int year;
            int month;
            int day;
            int totalDays = 0;

            Console.WriteLine("Año de nacimiento:");
            int.TryParse(Console.ReadLine(), out year);
            Console.WriteLine("Mes de nacimiento:");
            int.TryParse(Console.ReadLine(), out month);
            Console.WriteLine("Dia de nacimiento:");
            int.TryParse(Console.ReadLine(), out day);

            if (year <= 0 || month <= 0 || day <= 0)
            {
                Console.WriteLine("[ERROR] Revise los datos de entrada de la fecha de nacimiento");
                return;
            }
            DateTime birthDate = new DateTime(year, month, day);
            totalDays = (DateTime.Now.Date - birthDate.Date).Days;

            Console.WriteLine($"Dias totales vividos: {totalDays}");
        }
        public static void Ejercicio_09()
        {
            Console.Title = "Ejercicio 09";

            int height;
            char piramidIcon = '*';

            Console.WriteLine("Ingrese la altura de la piramide:");
            int.TryParse(Console.ReadLine(), out height);

            for (int row = 0; row < height; row++)
            {
                String piramid = new String(piramidIcon, 1 * row + 1);
                piramid = row > 0 ? piramid.PadRight(piramid.Length + row, piramidIcon) : $"{piramidIcon}";
                Console.WriteLine(piramid);
            }
        }
        public static void Ejercicio_10()
        {
            Console.Title = "Ejercicio 10";

            int height;
            char piramidIcon = '*';
            int padString;

            Console.WriteLine("Ingrese la altura de la piramide:");
            int.TryParse(Console.ReadLine(), out height);

            padString = height - 1;
            for (int row = 0; row < height; row++)
            {
                String piramid = new String(piramidIcon, 1 * row + 1);
                piramid = row > 0 ? piramid.PadRight(piramid.Length + row, piramidIcon) : $"{piramidIcon}";
                piramid = new String(' ', padString) + piramid;
                Console.WriteLine(piramid);
                padString--;
            }
        }
    }
}