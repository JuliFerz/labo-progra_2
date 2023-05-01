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
    }
}
