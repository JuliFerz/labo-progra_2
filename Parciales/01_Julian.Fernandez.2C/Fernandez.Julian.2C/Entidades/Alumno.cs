using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        #region Atributos
        private string legajo;
        private Dictionary<EMateria, List<int>> materiasAsignadas;
        #endregion

        #region Propiedades
        public override string Informacion { get => $"Alumno:\n{this.MostrarDatos()}"; }
        public List<int> this[EMateria materia]
        {
            get
            {
                if (this.materiasAsignadas.ContainsKey(materia))
                {
                    return this.materiasAsignadas[materia];
                }
                return null;
            }
        }
        #endregion

        #region Constructor
        private Alumno(int dni)
            : base(dni)
        {
            this.materiasAsignadas = new Dictionary<EMateria, List<int>>();
        }
        public Alumno(int dni, string legajo)
            : this(dni)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para mostrar los datos del alumno
        /// </summary>
        /// <returns>string</returns>
        protected override string MostrarDatos()
        {
            return $"{base.MostrarDatos()}\nLegajo: {this.legajo}\nMaterias: {string.Join(", ", this.materiasAsignadas.Keys)}";
        }

        /// <summary>
        /// Metodos para hacer rendir a un alumno
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        public bool RendirExamen(EMateria materia)
        {
            Random nroRandom = new Random();

            if (this.materiasAsignadas.ContainsKey(materia))
            {
                nroRandom.Next(1, 10);
                this.materiasAsignadas[materia].Add(nroRandom.Next(1, 10));
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobreescritura de tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Alumno - {this.legajo}";
        }
        #endregion


        #region Sobrecarga
        public static bool operator ==(Alumno alumno, EMateria materia)
        {
            return alumno.materiasAsignadas.ContainsKey(materia);
        }

        public static bool operator !=(Alumno alumno, EMateria materia)
        {
            return !(alumno == materia);
        }

        public static bool operator +(Alumno alumno, EMateria materia)
        {
            if (alumno != materia)
            {
                alumno.materiasAsignadas.Add(materia, new List<int>());
                return true;
            }
            return false;
        }

        public static implicit operator Alumno(string dni)
        {
            Alumno alumno = new Alumno(int.Parse(dni));
            alumno.legajo = $"{alumno.GetHashCode()}";

            return alumno;
        }
        #endregion
    }
}
