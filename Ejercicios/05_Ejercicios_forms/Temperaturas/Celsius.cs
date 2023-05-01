using System;
using System.Collections.Generic;
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
            return new Fahrenheit(c.temperatura * 9 / 5 + 32);
        }

        // Metodos
        public double GetTemperatura()
        {
            return this.temperatura;
        }
    }
}
