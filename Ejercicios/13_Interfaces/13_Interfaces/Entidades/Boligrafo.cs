using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color { get => this.colorTinta; set => this.colorTinta = value; }
        public float UnidadesDeEscritura { get => this.tinta; set => this.tinta = value; }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.tinta -= 0.3f;
            return new EscrituraWrapper(this.Color, texto);
        }
        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return false;
        }
        public override string ToString()
        {
            return $"Esto es un boligrafo y tiene {this.tinta} de tinta de color {this.colorTinta}";
        }
    }
}
