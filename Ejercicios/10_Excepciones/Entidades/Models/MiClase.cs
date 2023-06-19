using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Exceptions;


namespace Entidades.Models
{
    /*
     * Ejercicio_I01
     */
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                LanzarExcepcion();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public MiClase(int id)
        {
            try
            {
                new MiClase();
            }
            catch (Exception e)
            {
                throw new UnaExcepcion("Este es el constructor con parámetro de mi clase", e);
            }
        }

        public static void LanzarExcepcion()
        {
            throw new DivideByZeroException("Este es el método estático de mi clase");
        }
    }
}
