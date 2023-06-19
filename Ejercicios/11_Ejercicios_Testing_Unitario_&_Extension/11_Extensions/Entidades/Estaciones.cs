namespace Entidades
{
    public enum EEstaciones
    {
        Verano,
        Primavera,
        Invierno,
        Otonio
    }
    public class Estaciones
    {
        public static DateTime ObtenerFechaEstacion(EEstaciones estacion)
        {
            switch (estacion)
            {
                case EEstaciones.Verano:
                    return new DateTime(DateTime.Now.Year, 12, 21);
                case EEstaciones.Primavera:
                    return new DateTime(DateTime.Now.Year, 9, 21);
                case EEstaciones.Invierno:
                    return new DateTime(DateTime.Now.Year, 6, 21);
                case EEstaciones.Otonio:
                    return new DateTime(DateTime.Now.Year, 3, 21);
                default:
                    return new DateTime();
            }
        }
    }
}