namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Pesos()
        {
            Pesos.cotzRespectoDolar = 395;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            Pesos.cotzRespectoDolar = cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotzRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static explicit operator Dolar(Pesos peso)
        {
            return new Dolar(peso.cantidad / Pesos.cotzRespectoDolar);
        }
        public static explicit operator Euro(Pesos peso)
        {
            return (Euro)peso;
        }


        // Todo lo que está abajo, hacerlo en los demás métodos (ver diagrama)
        public static bool operator ==(Pesos p, Pesos p2)
        {
            return p.cantidad == p2.cantidad;
        }
        public static bool operator !=(Pesos p, Pesos p2)
        {
            // esto es sobrecarga el operador ==
            return !(p == p2);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.cantidad == ((Pesos)d).cantidad;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p.cantidad == ((Pesos)e).cantidad;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
    }




    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static explicit operator Pesos(Dolar dolar)
        {
            return new Pesos(dolar.cantidad * Pesos.GetCotizacion());
        }

    }






    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 0.9;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad / Euro.cotzRespectoDolar);
        }

        public static explicit operator Pesos(Euro euro)
        {
            return (Pesos)((Dolar)euro);
        }
    }

}