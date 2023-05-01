namespace Entidades
{
    public class Ej
    {
        public static void Ejercicio_26()
        {
            Random random = new Random();
            int[] numeros = new int[20];

            // Numeros positivos, sin contar con 0
            for (int i = 0; i < numeros.Length; i++) { numeros[i] = random.Next(1, 10) * (random.Next(2) == 0 ? -1 : 1); }

            Console.WriteLine("Numeros del array: ");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }

    }
}