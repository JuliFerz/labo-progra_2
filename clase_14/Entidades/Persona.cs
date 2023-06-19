namespace Entidades
{
    public class Persona
    {
        // Los valores que reciba estos dos son el valor del objeto
        private string nombre;
        private string apellido;
        //private List<int> numeros;

        public string Nombre { get => this.nombre; set => this.nombre = value;  }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        //public List<int> Numeros { get => numeros; set => numeros = value; }

        public Persona()
        {
            //this.Numeros = new List<int>();
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
}