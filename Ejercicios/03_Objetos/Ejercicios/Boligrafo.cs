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
            string trazo = "";
            bool retorno = false;
            this.SetTinta(gasto);
            if (this.tinta <= 0)
            {
                dibujo = "No se puede pintar";
            }
            else
            {
                while (gasto > 0 && this.tinta > 0)
                {
                    trazo += "*";
                    gasto--;
                    this.SetTinta(-1);
                }
                dibujo = trazo;
                retorno = true;
            }
            return retorno;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if (this.tinta < 0) { this.tinta = 0; }
            else if (this.tinta > Boligrafo.cantidadTintaMaxima) { this.tinta = Boligrafo.cantidadTintaMaxima; }
        }
    }
}