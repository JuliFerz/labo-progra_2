using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    // Heredo de Persona, pero sigo usando la interfaz IMensaje y otra más (IEnumerable) 
    //public class Cartero : Persona, IMensaje, IEnumerable<int>
    public class Cartero : IMensaje, IGenerica<string>, IGenerica<int>
    {
        private bool estado;
        public string Nombre { get; set; }

        // Implementación de la propiedad de la interfaz
        public bool Estado => this.estado;

        // Implementación del método de la interfaz
        // implicita
        public string EnviarMensaje()
        {
            this.estado = !this.estado;
            return "El cartero envía un mensaje";
        }

        // explicita
        // NombreInterface.NombreMiembro
        //string IMensaje.EnviarMensaje()
        //{
        //    this.estado = !this.estado;
        //    return "El cartero envía un mensaje explicitamente";
        //}

        string IGenerica<string>.EnviarMensaje()
        {
            this.estado = !this.estado;
            return "El cartero envía un mensaje desde la interfaz generica";
        }

        int IGenerica<int>.EnviarMensaje()
        {
            this.estado = !this.estado;
            return 0;
        }
    }
}
