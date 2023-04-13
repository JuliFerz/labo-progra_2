using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private string[] materias;

        // Con : this llamo al constructor anterior (el de arriba).
        // Se ejecuta este constructor, pero PRIMERO va al constructor de this (el de abajo)
        // asigna los valores a legajo, nombre y apellido y despues de eso entra en el body
        // de este constructor
        public Alumno(int legajo, string nombre, string apellido, string[] materias) : this(legajo, nombre, apellido)
        {
            this.materias = materias;
        }

        // SOBRECARGA de parametros
        public Alumno(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }


        // crear sobrecarga que permita comparar dos instancias (para saber si dos alumnos son iguales)
        // * todas las sobrecargas SIEMPRE van a ser estaticas (en este caso)
        //   ACLARACION: Si comento estos dos metodos, la comparacion == va a ser por referencia
        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            // * si se define esta sobrecarga, C# ya sabe que al comparar dos instancias no va a usar 
            //   el operador default (el que compara por referencia)
            // Esto comparar si tienen el mismo legajo
            return alumno1.legajo == alumno2.legajo;
        }

        // es requerido crear este porque el operador == necesita su contra parte (!=)
        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            // comparar si tienen el mismo legajo
            // * no hace falta colocar alumno.legajo porque ya lo va a comparar con la función de arriba
            return !(alumno1 == alumno2);
        }


        // ahora con: operador de casteo (operador de converción)
        // Sobrecarga de conversión
        // Forma IMPLICITA
        public static implicit operator string(Alumno alumno)
        {
            return $"{alumno.nombre} {alumno.apellido}";
        }

        // Forma EXPLICITA
        public static explicit operator int(Alumno alumno)
        {
            return alumno.legajo;
        }
    }
}
