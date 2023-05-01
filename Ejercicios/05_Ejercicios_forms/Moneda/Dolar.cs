namespace Moneda
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        // Constructor
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        // Sobrecarga de constructor
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de operador de conversión
        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        // Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
    }
}