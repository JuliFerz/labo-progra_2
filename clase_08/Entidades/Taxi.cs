using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //public sealed class Taxi : Vehiculo hace que la clase se selle 
    public class Taxi : Vehiculo
    {
        private string licencia;


        /*public Taxi(string matricula, string modelo, double potencia)
            : base(matricula, modelo, potencia) // pasar/inicializar parametros al objeto padre
        {
            // no hace falta inicializar las variables porque ya lo hace la clase padre
            //base.matricula = matricula; // base. funciona como this. pero es mejor base para hacer
                                        // referencia a algo de la clase padre y this para algo de esta subclase
        }*/
        public Taxi(string matricula, string modelo, double potencia)
            : base(matricula, modelo, potencia) { }

        public Taxi(string matricula, string modelo, double potencia, string licencia)
            : this(matricula, modelo, potencia)
        {
            this.Licencia = licencia;
        }
        public string Licencia { get => licencia; set => licencia = value; }

        public bool HacerCarrera()
        {
            return true;
        }
    }
}
