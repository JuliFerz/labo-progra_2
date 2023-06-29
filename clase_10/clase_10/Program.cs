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

            string? numeroA;
            string? numeroB;
            Calculadora calculadora;
            Console.WriteLine("Ingrese primer numero:");
            numeroA = Console.ReadLine();
            Console.WriteLine("Ingrese segundo numero:");
            numeroB = Console.ReadLine();

            //calculadora = new Calculadora(numeroA, numeroB);
            //Console.WriteLine($"El resultado de la división es: {calculadora.Dividir()}");
            //Console.WriteLine($"El resultado de la suma es: {calculadora.Sumar()}");
            try
            {
                calculadora = new Calculadora(numeroA, numeroB);
                Console.WriteLine($"El resultado de la división es: {calculadora.Dividir()}");
            }
            catch (FormatException ex) // El CLR busca por cada catch hasta que matchea con el tipo de error que se produjo
                                       // y entra en el bloque
            {
                Console.WriteLine("[1] Error de formato: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("[2] Error en división: " + ex.Message);
            }
            catch (Exception ex) // Es la más generica, por si no pudo encontrar la exception format, o por división por 0
                                 // Debe estar SI O SI al final de todo, porque esta excepción se va a capturar siempre
                                 // Es decir, si está al comienzo, SIEMPRE va a entrar en este bloque y no contempla los demás
            {
                Console.WriteLine("[ALL] Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("[FINALLY] Se ejecuta el bloque finally con/sin error");
            }

            Console.ReadKey();

            Exception e = new Exception("Primera excepcion");
            ArgumentoInvalidoException a = new ArgumentoInvalidoException("Mensaje A", e);
            ArgumentoInvalidoException b = new ArgumentoInvalidoException("Mensaje B", a);
            ArgumentoInvalidoException c = new ArgumentoInvalidoException("Mensaje C", b);

            Exception? bucle = c;
            /*
             * La primer excepción que tiene "bucle" es la variable C, la C tiene B, B -> A, A -> Exception
             * Le pongo ? al Exception para que esa variable sepa que puede ser nula (sino tengo warning)
             */
            while (bucle != null)
            {
                Console.WriteLine(bucle.Message); // output: Mensaje C; Mensaje B; Mensaje A; Primera excpecion
                bucle = bucle.InnerException;
                /*
                 * InnerException es la referencia de la expceción que se haya guardado sobre otra.
                 * En la otra iteración, "bucle" ahora tendrá la excepcion de "C", por lo que su siguiente InnerException
                 * despues será la "A", despues será la exception de "E" y despues bucle ya va a ser null 
                 * por lo que sale del while.
                 * 
                 * InnerException: Es ir a la excepción anterior, o a la guardada (
                 *      si es que se la pasa por parametro exception será la "B" (la variable "e" no tiene Inner))
                 */
            }
        }
    }
}