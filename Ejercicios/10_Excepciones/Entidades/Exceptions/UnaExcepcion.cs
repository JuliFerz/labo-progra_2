using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    /*
     * Ejercicio_I01
     */
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string? message) : base(message)
        {
        }

        public UnaExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
