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
            Pesos.cotizRespectoDolar = 220.226; // official dollar (from google)
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
    }
}