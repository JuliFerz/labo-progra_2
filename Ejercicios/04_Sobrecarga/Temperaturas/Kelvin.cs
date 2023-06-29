using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        private double temperatura;

        // Constructor
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        // Sobrecarga de operador de conversión
        public static implicit operator Kelvin(double temperatura)
        {
            return new Kelvin(temperatura);
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(k.temperatura - 273.15);
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.temperatura * 9 / 5 - 459.67);
        }

        // Metodos
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        // Sobrecarga de operador
        // ==
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.temperatura == ((Kelvin)c).temperatura;
        }
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.temperatura == ((Kelvin)f).temperatura;
        }
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.temperatura == k2.temperatura;
        }

        // !=
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        // +, -
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.temperatura - ((Kelvin)c).temperatura);
        }
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.temperatura - ((Kelvin)f).temperatura);
        }
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.temperatura + ((Kelvin)c).temperatura);
        }
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.temperatura + ((Kelvin)f).temperatura);
        }
    }
}
