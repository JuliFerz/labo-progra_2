using System.Text;

namespace Registro
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\n• Nombre: {this.nombre}");
            sb.Append($"\n • Edad: {this.edad}");
            sb.Append($"\n • Genero: {this.genero}");
            sb.Append($"\n • Pais: {this.pais}");
            sb.Append($"\n • Dirección: {this.direccion}");
            sb.Append($"\n • Cursos: {string.Join(", ", this.cursos)}");

            return $"\n\t{sb}";
        }
    }
}