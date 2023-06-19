using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public static class ClaseCalculador
    {
        /// <summary>
        /// Método para calcular la division de dos numeros enteros
        /// </summary>
        /// <param name="nro1">numero entero</param>
        /// <param name="nro2">numero entero</param>
        /// <returns>Resultado (en float) de la ivisión de dos numeros</returns>
        /// <exception cref="DivideByZeroException">Excepción que se lanza si divisor es 0</exception>
        public static float Calcular(int nro1, int nro2)
        {
            if (nro2 == 0)
                throw new DivideByZeroException();
            return (float)nro1 / nro2;
        }
    }
}
