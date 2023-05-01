namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        // Constructor
        static Euro()
        {
            Euro.cotizRespectoDolar = 0.91;
        }
        // Sobrecarga de constructor
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de operador de conversión
        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.cotizRespectoDolar);
        }
        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e); // siempre cotiza respecto a dolar
        }

        // Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de operador
        // ==
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.cantidad == ((Euro)d).cantidad;
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e.cantidad == ((Euro)p).cantidad;
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        // !=
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        // +, -
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).GetCantidad());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).GetCantidad());
        }
    }
}