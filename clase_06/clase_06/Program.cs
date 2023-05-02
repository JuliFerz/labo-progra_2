namespace clase_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instancia e inicialización
            int[] edades = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine(edades[3]);

            Array.Resize(ref edades, 2);
            Console.WriteLine(edades[1]); // 2
            //Console.WriteLine(edades[3]);


            // matriz multidimensional
            int[,] numeros = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // Es una matriz de int[3,2]
                                                               // 3 sub-elementos
                                                               // 2 elementos por cada sub-elemento
            Console.WriteLine(numeros[1, 1]); // 4



            // listas
            Console.WriteLine("\n");
            List<string> listaNombres = new List<string>();
            listaNombres.Add("A");
            listaNombres.Add("B");
            listaNombres.Add("C");
            foreach (var el in listaNombres) { Console.WriteLine(el); } // A;B;C
            listaNombres.Insert(listaNombres.Count-1, "Test");
            Console.WriteLine("\n");
            foreach (var el in listaNombres) { Console.WriteLine(el); } // A;B;Test,C
            Console.WriteLine("\n");
            Console.WriteLine($"TEST: {string.Join(", ", listaNombres)}");


            Console.WriteLine("\n");

            Queue<int> cola = new Queue<int>();
            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);
            cola.Enqueue(5);
            foreach (var el in cola) { Console.WriteLine(el); } // 1; 2; 3; 4; 5
            Console.WriteLine(cola.Dequeue());
            Console.WriteLine("\n");
            foreach (var el in cola) { Console.WriteLine(el); } // 2; 3; 4; 5


            Console.WriteLine("\n");

            SortedList<int, string> sortedList = new SortedList<int, string>();

            sortedList.Add(90, "Hola");
            sortedList.Add(1, "Mundo");

            foreach (var item in sortedList) // "item" es un keyvaluepair
            {
                Console.WriteLine(item); // [1, Mundo]; [90, Hola]
                Console.WriteLine(item.Key); // 1; 90
                Console.WriteLine(item.Value); // Mundo; Hola
                                               // Aparece en ese orden porque la ordena (por eso no aparece primero hola y despues mundo, sino pirmero "Mundo" y despeus "hola")
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }
    }
}