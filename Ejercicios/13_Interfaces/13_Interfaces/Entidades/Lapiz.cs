using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public ConsoleColor Color { get => ConsoleColor.Red; set => throw new NotImplementedException(); }
        public float UnidadesDeEscritura { get => this.tamanioMina; set => this.tamanioMina = value; }

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.tamanioMina -= 0.1f;
            return new EscrituraWrapper(this.Color, texto);
        }
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Esto es un lapiz y a la mina le queda un tamanio de {this.tamanioMina}";
        }
    }
}
