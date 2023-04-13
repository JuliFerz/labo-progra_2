namespace Entidades
{
    public class Persona
    {
        public static string familia;
        public int edad;
        public string nombre;
        public string apellido;

        // CONSTRUCTOR ESTATICO
        static Persona()
        {
            Persona.familia = "Mono"; // mejor asignar familia acá que en la asignación (linea 5)
        }

        // CONSTRUCTOR NO estatico
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        // es solo de prueba. lo recomendable es que el método también sea estatico,
        // ya que trabaja sobre un campo static (cumplir con el mismo tipo)
        public void CambiarFamilia(string familia)
        {
            Persona.familia = familia;
        }
    }
}