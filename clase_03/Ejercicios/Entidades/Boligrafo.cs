namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor() { return this.color; }

        public short GetTinta() { return this.tinta; }

        public bool Pintar(short gasto, out string dibujo)
        {
            if (this.tinta <= 0)
            {
                dibujo = "No se puede pintar";
                return false;
            }
            dibujo = "Puedo pintar";
            return true;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            bool condition = this.tinta >= 0 && this.tinta <= Boligrafo.cantidadTintaMaxima;
            this.tinta = condition ? (short)(this.tinta + tinta) : this.tinta;

            if (this.tinta >= 0 && this.tinta <= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }



    }
}