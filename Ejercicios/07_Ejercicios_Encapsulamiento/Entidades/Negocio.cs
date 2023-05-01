namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> cliente;
        private string nombre;

        public Cliente Cliente
        {
            get { }
            set { }
        }

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
            this.cliente = new Queue<Cliente>();
        }
        public Negocio(string nombre)
        {

        }

        public static bool operator ~(Negocio n)
        {
            return false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            return false;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.Equals(c);
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n.Equals(c));
        }
    }
}