using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celsius
    {
        private double temperatura;

        // Constructor
        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        // Sobrecarga de operador de conversión
        public static implicit operator Celsius(double temperatura)
        {
            return new Celsius(temperatura);
        }
        public static explicit operator Kelvin(Celsius c)
        {
            //return new Kelvin(k.temperatura / Celsius.temperatura);
            return new Kelvin(c.temperatura + 273.15);
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.temperatura * 9/5 + 32);
        }

        // Metodos
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        // Sobrecarga de operador
        // ==
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.temperatura == ((Celsius)k).temperatura;
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.temperatura == ((Celsius)f).temperatura;
        }
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.temperatura == c2.temperatura;
        }

        // !=
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        // +, -
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.temperatura - ((Celsius)k).temperatura);
        }
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.temperatura - ((Celsius)f).temperatura);
        }
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.temperatura + ((Celsius)k).temperatura);
        }
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.temperatura + ((Celsius)f).temperatura);
        }

    }
}
