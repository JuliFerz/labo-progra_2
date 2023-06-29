using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
     * Fechas de estaciones:
     *    • Otoño (21 de marzo a 20 de junio).
     *    • Invierno (21 de junio a 20 de septiembre
     *    • Primavera (21 de septiembre a 20 de diciembre).
     *    • Verano (21 de diciembre a 20 de marzo).
     */
    public static class MetodosExtension
    {
        /* Ejercicio_I01 */
        public static string ObtenerPlacaCronicaTV(this DateTime fecha, EEstaciones estacion)
        {
            DateTime fechaEstacion = Estaciones.ObtenerFechaEstacion(estacion);
            int resultadoFecha = (fechaEstacion.Date - fecha.Date).Days;
            if (resultadoFecha < 0)
            {
                fechaEstacion = fechaEstacion.AddYears(1);
                resultadoFecha = (fechaEstacion.Date - fecha.Date).Days;
            }
            return $"Faltan {resultadoFecha} dias para {estacion.ToString().ToLower()}";
        }

        /* Ejercicio_I02 */
        public static int ContarCantidadDeDigitos(this Int64 nro)
        {
            return nro.ToString().Length;
        }
    }
}
