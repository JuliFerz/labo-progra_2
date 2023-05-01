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
    }
}
