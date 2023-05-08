using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        #region Atributos
        private string email;
        private EMateria materiaAsignada;
        #endregion

        #region Propiedades
        public override string Informacion { get => $"Profesor:\n{this.MostrarDatos()}"; }
        public EMateria Materia { get => this.materiaAsignada; set => this.materiaAsignada = value; }
        #endregion


        #region Constructor
        public Profesor(int dni)
            : base(dni) { }

        public Profesor(int dni, string email)
            : this(dni)
        {
            this.email = email;
        }
        public Profesor(int dni, string email, EMateria materiaAsignada)
            : this(dni, email)
        {
            this.materiaAsignada = materiaAsignada;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para evaluar a un alumno
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public bool Evaluar(Alumno alumno)
        {
            return alumno.RendirExamen(this.materiaAsignada);
        }
        /// <summary>
        /// Metodo para mostrar los datos del profesor
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            return $"{base.MostrarDatos()}\nEmail: {this.email}\nMateria asignada: {this.materiaAsignada}";
        }
        /// <summary>
        /// Sobreescritura de tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Profesor - {this.materiaAsignada}";
        }
        #endregion
    }
}
