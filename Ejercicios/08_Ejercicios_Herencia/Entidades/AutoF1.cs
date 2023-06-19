namespace Ejercicio_36
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(string escuderia, short numero) : base(escuderia, numero) { }
        public AutoF1(string escuderia, short numero, short caballosDeFuerza) : this(escuderia, numero)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public static bool operator ==(AutoF1 a, AutoF1 b)
        {
            // Es posible el casteo porque AutoF1 es un tipo de VehiculoDeCarrera
            return (VehiculoDeCarrera)a == (VehiculoDeCarrera)b && a.caballosDeFuerza == b.caballosDeFuerza;
        }
        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }
        public new string MostrarDatos()
        {
            return $"Soy un autoF1 con {caballosDeFuerza} caballos de fuerza";
        }
    }
}