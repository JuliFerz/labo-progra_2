using Entidades.Exceptions;
using Entidades.Models;

namespace _10_Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.Ejercicio_I01();
            Program.Ejercicio_I02();
        }

        public static void Ejercicio_I01()
        {
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.MetodoInstancia();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void Ejercicio_I02()
        {
            /*
             * En el proyecto Form
             */
        }
    }
}