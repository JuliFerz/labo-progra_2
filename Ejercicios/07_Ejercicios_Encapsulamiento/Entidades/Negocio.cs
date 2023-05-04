namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> cliente;
        private string nombre;
        private Negocio()
        {
            this.cliente = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
        }
        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return cliente.Dequeue(); }
            set
            {
                if (this != value)
                {
                    // _ Es un identificador valido (es decir, se puede usar como asignación)
                    // Despues de la asignación, "_" pierde su valor.
                    _ = this + value;
                }
            }
        }

        public int ClientesPendientes { get => this.cliente.Count(); }
        public string Nombre { get => this.nombre; }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente) ? true : false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c)
            {
                n.cliente.Enqueue(c);
                return true;
            }
            return false;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            if (!n.cliente.Contains(c))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
    }
}