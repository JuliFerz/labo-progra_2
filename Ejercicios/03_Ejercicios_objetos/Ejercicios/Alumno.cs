using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private Random nroRandom = new Random();
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        string nombre = string.Empty;
        string apellido = string.Empty;
        int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4) { this.notaFinal = nroRandom.Next(1, 10); }
            else { this.notaFinal = -1; }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string mensaje = string.Empty;

            this.CalcularFinal();
            if (this.notaFinal > 0)
            { mensaje = $"• [{this.legajo}] Alumno: {this.apellido.ToUpper()}, {this.nombre} | Nota final: {this.notaFinal} ({this.nota1}/{this.nota2})"; }
            else
            { mensaje = $"• [{this.legajo}] Alumno: {this.apellido.ToUpper()}, {this.nombre} | Desaprobado ({this.nota1}/{this.nota2})"; }

            return mensaje;
        }
    }
}
