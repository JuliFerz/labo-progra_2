using Entidades;

namespace _07_Ejercicios_Encapsulamiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            PuestoAtencion kiosco = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
            Negocio n = new Negocio("Kiosco24");
            Cliente c1 = new Cliente(3, "Santos");
            Cliente c2 = new Cliente(2, "Medina");
            Cliente c3 = new Cliente(3, "Lamponne");
            Cliente c4 = new Cliente(4, "Ravenna");

            /* Cliente */
            Console.WriteLine("Cliente -----------");
            Console.WriteLine(c1 == c3); // true
            Console.WriteLine(c2 == c4); // false
            Console.WriteLine(c1 != c2); // true

            Console.WriteLine(c1.Nombre); // Santos
            Console.WriteLine(c2.Numero); // 2

            /* Negocio */
            Console.WriteLine("\nNegocio -----------");
            Console.WriteLine(n.Nombre); // "Kiosco24"
            if (n + c1)
            {
                Console.WriteLine("Se agrego c1 a la cola");
            }

            if (!(n + c1))
            {
                Console.WriteLine("Cliente c1 ya esta en la cola");
            }

            if (n + c2)
            {
                Console.WriteLine("Se agrego c2 a la cola");
            }

            if (n + c3)
            {
                Console.WriteLine("Se agrego c3 a la cola");
            }

            Console.WriteLine("Clientes pendientes: {0}", n.ClientesPendientes);

            while (~n)
            {
                Console.WriteLine("Clientes pendientes: {0}", n.ClientesPendientes);
            }

        }
    }
}