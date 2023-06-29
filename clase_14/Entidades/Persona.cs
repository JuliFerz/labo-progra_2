namespace Entidades
{
    public class Persona
    {
        // Los valores que reciba estos dos son el valor/estado del objeto
        private string nombre;
        private string apellido;
        private int edad;
        //private List<int> numeros;

        // Son requeridos las Propiedades para poder extraer el valor de los atributos del objeto.
        // Sino no es posible obtener el valor de dicho atributo.
        public string Nombre { get => this.nombre; set => this.nombre = value;  }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public int Edad { get => this.edad; set => this.edad = value; }

        public Persona()
        {
        }
        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

    }
}