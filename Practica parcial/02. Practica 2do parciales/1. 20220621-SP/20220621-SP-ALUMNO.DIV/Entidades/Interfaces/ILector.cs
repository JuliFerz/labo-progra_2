using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ILector
    {
        // Parece abstract en el diagrama, pero es así:
        public string ObtenerNuevaPalabra();
    }
}
