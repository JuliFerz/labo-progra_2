using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        #region Atributos
        private List<Persona> alumnos;
        private EMateria materia;
        private Persona profesor;
        #endregion


        #region Propiedades
        public List<Persona> Alumnos { get => this.alumnos; }
        public Profesor Profesor { get => (Profesor)this.profesor; set => this.profesor = value; }
        #endregion


        #region Constructor
        public Curso(Profesor profesor)
        {
            this.materia = profesor.Materia;
            this.profesor = profesor;
            this.alumnos = new List<Persona>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para evaluar a los alumnos
        /// </summary>
        /// <param name="curso"></param>
        public static void EvaluarAlumnos(Curso curso)
        {
            foreach (Alumno alumno in curso.Alumnos)
            {
                alumno.RendirExamen(curso.materia);
            }
        }
        /// <summary>
        /// Metodo para inscribir un alumno al curso (en caso de no existir en él)
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public string InscribirAlumno(Alumno alumno)
        {
            if (!this.alumnos.Contains(alumno) && alumno + this.materia)
            {
                this.Alumnos.Add(alumno);
                return $"Se inscribio al alumno a la materia {this.materia}\n{alumno.Informacion}";
            }
            return $"Ya inscripto o no se pudo inscribir el alumno a la materia {this.materia}";
        }
        /// <summary>
        /// Metodo para mostrar información del curso
        /// </summary>
        /// <param name="curso"></param>
        /// <returns></returns>
        public static string MostrarInformacionDelCurso(Curso curso)
        {
            return $"{curso.ToString()}\nAlumnos inscriptos: {string.Join(", ", curso.Alumnos)}";
        }
        public override string ToString()
        {
            return $"Curso de {this.materia}";
        }
        #endregion

        #region Sobrecarga
        public static bool operator ==(Curso curso, Alumno alumno)
        {
            return curso.Alumnos.Contains(alumno);
        }
        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso == alumno);
        }
        #endregion
    }
}
