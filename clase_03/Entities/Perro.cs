using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro
    {
        public Persona duenio;
        public string nombre;
        public int edad;

        public string Saludar()
        {
            // this hace referencia a la variable del objeto
            return $"Guau guau! mi nombre es {this.nombre}";
        }
    }
}
