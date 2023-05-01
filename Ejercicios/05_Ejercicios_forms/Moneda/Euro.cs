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
    }
}