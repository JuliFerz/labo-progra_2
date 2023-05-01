namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get { }
            set { }
        }
        public int Numero
        {
            get { }
        }

        public Cliente(int numero)
        {

        }
        public Cliente(int numero, string nombre)
        {

        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero.Equals(c2.numero);
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1.Equals(c2));
        }
    }
}