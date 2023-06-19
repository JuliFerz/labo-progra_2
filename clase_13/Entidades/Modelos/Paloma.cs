using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Paloma : IMensaje
    {
        private bool estado;
        public bool Estado => throw new NotImplementedException();

        string IMensaje.EnviarMensaje()
        {
            this.estado = !this.estado;
            return "La paloma envía un mensaje";
        }
    }
}
