using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                new MiClase(1);
            }
            catch (Exception e)
            {
                throw new MiExcepcion("Mi excepcion en la instancia de mi OtraClase", e);
            }

        }
    }
}
