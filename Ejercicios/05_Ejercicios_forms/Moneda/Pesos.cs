namespace Moneda
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        // Constructor
        static Pesos()
        {
            //Pesos.cotizRespectoDolar = 462; // blue dollar (arg)
            //Pesos.cotizRespectoDolar = 220.226; // official dollar (from google)
            Pesos.cotizRespectoDolar = 1; // official dollar (from google)
        }
        // Sobrecarga de constructor
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de operador de conversión
        public static implicit operator Pesos(double cantidad)
        {
            return new Pesos(cantidad);
        }
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.cotizRespectoDolar);
        }
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p); // siempre cotiza respecto a dolar
        }

        // Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de operador
        // ==
        public static bool operator ==(Pesos p, Dolar d)
        {
            return (int)p.cantidad == (int)((Pesos)d).cantidad;
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return (int)p.cantidad == (int)((Pesos)e).cantidad;
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        // !=
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        // +, -
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).cantidad);
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).cantidad);
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).cantidad);
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).cantidad);
        }
    }
}