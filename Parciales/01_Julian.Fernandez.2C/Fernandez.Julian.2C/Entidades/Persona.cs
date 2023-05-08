using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {

        #region Atributos
        private string apellido;
        private string nombre;
        protected int dni;
        #endregion

        #region Propiedades
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public abstract string Informacion { get; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        #endregion


        #region Constructor
        protected Persona(int dni)
        {
            this.dni = dni;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescritura de metodo equals para comparar dni
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is not null && obj is Persona p)
            {
                retorno = this.dni == p.dni ? true : false;
            }
            return retorno;
        }
        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }
        /// <summary>
        /// Metodo base para mostrar datos de la persona
        /// </summary>
        /// <returns>string</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nDNI: {this.dni}");
            sb.Append($"\nApellido: {this.apellido}");
            sb.Append($"\nNombre: {this.nombre}");

            return $"{sb}";
        }
        #endregion

        #region Sobrecarga
        public static bool operator ==(Persona personaA, Persona personaB)
        {
            return personaA.Equals(personaB);
        }
        public static bool operator !=(Persona personaA, Persona personaB)
        {
            return !(personaA == personaB);
        }
        #endregion

    }
}