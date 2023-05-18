using Entidades.Models;
using Entidades.Exceptions;

namespace clase_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // El parametro Exception (3ra sobrecarga) permite almacenar otra exception
            //Exception e = new Exception();

            string numeroA;
            string numeroB;
            Calculadora calculadora;
            Console.WriteLine("Ingrese primer numero:");
            numeroA = Console.ReadLine();
            Console.WriteLine("Ingrese segundo numero:");
            numeroB = Console.ReadLine();

            calculadora = new Calculadora(numeroA, numeroB);
            Console.WriteLine($"El resultado de la división es: {calculadora.Dividir()}");
            //Console.WriteLine($"El resultado de la suma es: {calculadora.Sumar()}");
            try
            {
                calculadora = new Calculadora(numeroA, numeroB);
                Console.WriteLine($"El resultado de la división es: {calculadora.Dividir()}");
            }
            catch (FormatException ex) // El CLR busca por cada catch hasta que matchea con el tipo de error que se produjo
                                       // y entra en el bloque
            {
                Console.WriteLine("Error de formato: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error en división: " + ex.Message);
            }
            catch (Exception ex) // Es la más generica, por si no pudo encontrar la exception format, o por división por 0
                                 // Debe estar SI O SI al final de todo, porque esta excepción se va a capturar siempre
                                 // Es decir, si está al comienzo, SIEMPRE va a entrar en este bloque
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Se ejecuta el bloque finally con/sin error");
            }

            Console.ReadKey();

            Exception e = new Exception("Primera excpecion");
            ArgumentoInvalidoException a = new ArgumentoInvalidoException("Mensaje A", e);
            ArgumentoInvalidoException b = new ArgumentoInvalidoException("Mensaje B", a);
            ArgumentoInvalidoException c = new ArgumentoInvalidoException("Mensaje C", b);

            Exception bucle = c.InnerException; // la primer excepción que tiene C es la B
            while (bucle != null)
            {
                Console.WriteLine(bucle.Message); // output: Mensaje B; Mensaje A; Primera excpecion
                bucle = bucle.InnerException; // InnerException es la referencia de la primer expceción (b)
                                              // En la otra iteración, bucle ahora tendrá la excepcion de b, por lo que su innerexception será la "a"
                                              // despues será la "e", y despues bucle ya va a ser null por lo que sale del while
                                              // InnerException: Voy a la excepción anterior (si es que se la pasa por parametro
                                              //                                              (la variable "e" no tiene Inner))
            }
        }
    }
}