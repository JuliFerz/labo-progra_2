using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autobus : Vehiculo
    {
        private int numeroPlazas;
        public Autobus(string matricula, string modelo, double potencia)
            : base(matricula, modelo, potencia) { }
        public Autobus(string matricula, string modelo, double potencia, int numeroPlazas)
            : base(matricula, modelo, potencia)
        {
            this.NumeroPlazas = numeroPlazas;
        }

        public int NumeroPlazas { get => numeroPlazas; set => numeroPlazas = value; }

        public string HacerRecorrido()
        {
            return "Estoy haciendo mi recorrido normal :)";
        }
    }
}
