namespace clase_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CancellationTokenSource cancellation = new CancellationTokenSource();
            CancellationToken token = cancellation.Token;

            ConsoleKey teclaPresionada;
            //Task task = new Task(ImprimirHora);
            //task.Start(); // se ejecuta el hilo secundario que va a imprimir el metodo
            Task task = Task.Run(() => ImprimirHora(cancellation), token); // manera resumida

            //Task task = Task.Run(ImprimirHora); // la sobrecarga"cancellation token" finaliza el hilo
            do
            {
                teclaPresionada = Console.ReadKey().Key;
                Console.Write($"Presiono: {teclaPresionada}\n");
                if (teclaPresionada == ConsoleKey.Spacebar)
                {
                    cancellation.Cancel(); // hace que la propiedad IsCancellationRequested sea True
                }

            } while (teclaPresionada != ConsoleKey.Escape);
            //ImprimirHora();

            Console.WriteLine("Presiono escape, salí del primer do while");*/





            /* EJEMPLO DEL PROFE */
            Task tarea = new Task(Mimetodo);
            Task tarea2 = new Task(Mimetodo);
            Task tarea3 = new Task(Mimetodo);

            tarea.Start();
            tarea2.Start();
            tarea3.Start();
            Console.WriteLine($"ID hilo principal en el main{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("La tarea esta iniciada e imprimo en paralelo 1");
            Console.WriteLine("La tarea esta iniciada e imprimo en paralelo 2");
            Console.WriteLine("La tarea esta iniciada e imprimo en paralelo 3");
            Console.WriteLine("La tarea esta iniciada e imprimo en paralelo 4");
            Console.WriteLine("Termino la tarea primaria");

            // Indica que antes de que termine el hilo prinmcipal, espera a que termina la tarea (hilo secundario)
            tarea.Wait();

            Console.WriteLine("Termino la tarea secundaria");
            Console.ReadKey();
        }

        /*static void ImprimirHora(CancellationTokenSource cancellation)
        {
            do
            {
                Console.WriteLine($"{DateTime.Now}");
                Thread.Sleep(1000); // suspende la ejecución del hilo por un segundo (1000ms)
                //Console.Clear();
            } while(true && !cancellation.IsCancellationRequested); // true y la cancelación no sea requerida
        }*/



        /* EJEMPLO DEL PROFE */
        static void Mimetodo()
        {
            Console.WriteLine($"ID hilo en el main{Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iteracion numero {i+1}");
                Thread.Sleep(500);
            }
        }
    }
}