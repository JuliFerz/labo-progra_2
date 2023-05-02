namespace Entidades
{
    public class Ej
    {
        public static void Ejercicio_26()
        {
            Random random = new Random();
            int[] numeros = new int[20];

            // Numeros positivos, sin contar con 0
            for (int i = 0; i < 20; i++) { numeros[i] = random.Next(1, 100) * (random.Next(0, 2) == 1 ? 1 : -1); }

            Console.WriteLine("Numeros del array: ");
            foreach (int i in numeros) { Console.WriteLine(i); }

            Console.WriteLine("\nPositivos ordenados de forma decreciente: ");
            Array.Sort(numeros, (n1, n2) => n2 - n1);
            foreach (int nro in numeros.Where(x => x > 0)) { Console.WriteLine(nro); }

            Console.WriteLine("\nNegativos ordenados de forma creciente: ");
            Array.Sort(numeros);
            foreach (int nro in numeros.Where(x => x < 0)) { Console.WriteLine(nro); }
        }

        public static void Ejercicio_27()
        {
            Random random = new Random();


            /********* LISTA *********/
            Console.WriteLine("------------------- Lista");
            List<int> numerosL = new List<int>();

            // Cargo numeros positivos, sin contar con 0
            for (int i = 0; i < 20; i++) { numerosL.Add(random.Next(1, 100) * (random.Next(0, 2) == 1 ? 1 : -1)); }

            /* Numeros */
            Console.WriteLine("Numeros de la lista: ");
            foreach (int i in numerosL) { Console.WriteLine(i); }

            /* Orden Decreciente */
            Console.WriteLine("\nPositivos ordenados de forma decreciente: ");
            numerosL.Sort((n1, n2) => n2 - n1);
            foreach (int nro in numerosL.Where(x => x > 0)) { Console.WriteLine(nro); }

            /* Orden Creciente */
            Console.WriteLine("\nNegativos ordenados de forma creciente: ");
            numerosL.Sort();
            foreach (int nro in numerosL.Where(x => x < 0)) { Console.WriteLine(nro); }



            /********* PILA *********/
            Console.WriteLine("\n------------------- Stack (LIFO)");
            Stack<int> numerosS = new Stack<int>();
            Stack<int> stackPositivos;
            Stack<int> stackNegativos;

            // Cargo numeros positivos, sin contar con 0
            for (int i = 0; i < 20; i++) { numerosS.Push(random.Next(1, 100) * (random.Next(0, 2) == 1 ? 1 : -1)); }
            List<int> auxStack = numerosS.ToList(); // Asigno en una variable auxiliar los numeros de queue casteado a lista

            /* Numeros */
            Console.WriteLine("Numeros de la pila: ");
            foreach (int i in numerosS) { Console.WriteLine(i); }

            /* Orden Decreciente */
            Console.WriteLine("\nPositivos ordenados de forma decreciente: ");
            auxStack.Sort(); // Ordeno la lista decrecientemente
            stackPositivos = new Stack<int>(auxStack.Where(x => x > 0)); // Inicializo stackPositivos casteando a stack la lista
                                                                         // donde los numeros sean mayor a 0
            foreach (int i in stackPositivos) { Console.WriteLine(i); }

            /* Orden Creciente */
            Console.WriteLine("\nNegativos ordenados de forma creciente: ");
            auxStack.Sort((n1, n2) => n2 - n1);
            stackNegativos = new Stack<int>(auxStack.Where(x => x < 0));
            foreach (int nro in stackNegativos.Where(x => x < 0)) { Console.WriteLine(nro); }




            /********* COLA *********/
            Console.WriteLine("\n------------------- Queue (FIFO)");
            Queue<int> numerosQ = new Queue<int>();
            Queue<int> queuePositivos;
            Queue<int> queueNegativos;

            // Cargo numeros positivos, sin contar con 0
            for (int i = 0; i < 20; i++) { numerosQ.Enqueue(random.Next(1, 100) * (random.Next(0, 2) == 1 ? 1 : -1)); }
            List<int> auxQueue = numerosQ.ToList(); // Asigno en una variable auxiliar los numeros de queue casteado a lista

            /* Numeros */
            Console.WriteLine("Numeros de la cola: ");
            foreach (int i in numerosQ) { Console.WriteLine(i); }

            /* Orden Decreciente */
            Console.WriteLine("\nPositivos ordenados de forma decreciente: ");
            auxQueue.Sort((n1, n2) => n2 - n1); // Ordeno la lista decrecientemente
            queuePositivos = new Queue<int>(auxQueue.Where(x => x > 0)); // Inicializo queuePositivos casteando a queue la lista
                                                                         // donde los numeros sean mayor a 0
            foreach (int i in queuePositivos) { Console.WriteLine(i); }

            /* Orden Creciente */
            Console.WriteLine("\nNegativos ordenados de forma creciente: ");
            auxQueue.Sort();
            queueNegativos = new Queue<int>(auxQueue.Where(x => x < 0));
            foreach (int nro in queueNegativos.Where(x => x < 0)) { Console.WriteLine(nro); }
        }
    }
}