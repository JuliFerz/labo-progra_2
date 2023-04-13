using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_l02
{
    public class Persona
    {
        private int dni;

        // constructor privado
        private Persona(int dni)
        {
            this.dni = dni;
        }

        // getter
        public int GetDni()
        {
            return this.dni;
        }

        public static implicit operator Persona(int dni)
        {
            return new Persona(dni);
        }

        // Otra manera de hacerlo
        public static implicit operator int(Persona p)
        {
            return p.dni;
        }

    }
}
