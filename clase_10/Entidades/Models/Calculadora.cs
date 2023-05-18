using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Entidades.Exceptions;

namespace Entidades.Models
{
    public class Calculadora
    {
        private int numeroA;
        private int numeroB;

        public Calculadora(string numeroA, string numeroB)
        {
            this.ConvierteNumero(numeroA, out this.numeroA);
            this.ConvierteNumero(numeroB, out this.numeroB);
        }


        public double Dividir()
        {
            /*try
            {
                return this.numeroA / this.numeroB;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error al dividir: {ex.Message}");
                return -1;
            }*/
            //return this.numeroA / this.numeroB; // si no tiene try-catch el CLR 20.43


            /*try
            {
                Console.WriteLine("Esto se ejecuta despues.");
                return this.numeroA / this.numeroB;
            }
            finally
            {
                Console.WriteLine("Esto se ejecuta siempre dentro de dividir()");
            }*/

            try
            {
                return this.numeroA / this.numeroB;
            }
            catch (DivideByZeroException ex)
            {
                throw new ArgumentoInvalidoException("El divisor no puede ser cero", ex);
            }
        }
        public double Multiplicar()
        {
            return this.numeroA * this.numeroB;
        }
        public double Sumar()
        {
            return this.numeroA + this.numeroB;
        }
        public double Restar()
        {
            return this.numeroA - this.numeroB;
        }
        //private bool ConvierteNumero(string numero, out int resultado)
        private void ConvierteNumero(string numero, out int resultado)
        {
            /*bool retorno = false;
            try
            {
                resultado = int.Parse(numero);
                Console.WriteLine("No ejecuta"); // si el try rompe, esto no se ejecuta ( si estuviera descomentado ) 
                retorno = true;
            }
            //catch (Exception e) // Este parametro permite calcular exception, pero de la más genérica (porque es de la clase exception)
            catch (FormatException e) // calculo un exception más específico (FormatException)
            {
                resultado = 0; // es necesario porque sino VS comenta que si se entra a catch y no se encuentra resultado, entonces la variable va a quedar sin valor
                Console.WriteLine("Si ejecuta"); // si el try rompe, esto si se ejecuta ( si estuviera descomentado ) 
                Console.WriteLine($"Error de formato {e.Message}");
            }
            Console.WriteLine("Este es el final del metodo"); // si el try rompe o no, esto no se ejecuta igual porque esta fuera del try/catch( si estuviera descomentado ) 

            return retorno;*/

            resultado = int.Parse(numero);
        }
    }
}
