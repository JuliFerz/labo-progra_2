using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IMensaje
    {
        // Por defecto siempre son publicos (no es necesario declarar la visibilidad)
        public string EnviarMensaje();
        public bool Estado { get; }
    }
}
