using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Fahrenheit
    {
        private double temperatura;

        // Constructor
        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        // Sobrecarga de operador de conversión
        public static implicit operator Fahrenheit(double temperatura)
        {
            return new Fahrenheit(temperatura);
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.temperatura + 459.67) * 5 / 9);
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.temperatura - 32) * 5 / 9);
        }

        // Metodos
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        /*public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }*/

        // Sobrecarga de operador
        // ==
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.temperatura == ((Fahrenheit)k).temperatura;
        }
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.temperatura == ((Fahrenheit)c).temperatura;
        }
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.temperatura == f2.temperatura;
        }

        // !=
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        // +, -
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.temperatura - ((Fahrenheit)k).temperatura);
        }
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.temperatura - ((Fahrenheit)c).temperatura);
        }
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.temperatura + ((Fahrenheit)k).temperatura);
        }
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.temperatura + ((Fahrenheit)c).temperatura);
        }
    }
}