using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindradas;

        public MotoCross(string escuderia, short numero) : base(escuderia, numero) { }
        public MotoCross(string escuderia, short numero, short cilindradas) : this(escuderia, numero)
        {
            this.cilindradas = cilindradas;
        }

        public static bool operator ==(MotoCross a, MotoCross b)
        {
            // Es posible el casteo porque AutoF1 es un tipo de VehiculoDeCarrera
            return (VehiculoDeCarrera)a == (VehiculoDeCarrera)b && a.cilindradas == b.cilindradas;
        }
        public static bool operator !=(MotoCross a, MotoCross b)
        {
            return !(a == b);
        }

        public new string MostrarDatos()
        {
            return $"Soy una MotoCross con {cilindradas} cilindradas";
        }
    }
}
