using Entidades;

namespace Fernandez.Julian._2C
{
    public partial class Inscripcion : Form
    {
        private Persona alumno;
        private Persona profesorProgra;
        private Curso cursoProgramacion;
        private Persona profesorLabo;
        private Curso cursoLaboratorio;
        public Inscripcion()
        {
            InitializeComponent();
            profesorLabo = new Profesor(99000123, "profesorLabo @email.com & ", EMateria.Laboratorio);
            profesorProgra = new Profesor(99000123, "profesorProgra @email.com & ", EMateria.Programacion);
            cursoProgramacion = new Curso((Profesor)profesorProgra);
            cursoLaboratorio = new Curso((Profesor)profesorLabo);
        }

        // Load
        private void Inscripcion_Load(object sender, EventArgs e)
        {
            this.cbMaterias.DataSource = Enum.GetValues(typeof(EMateria));
        }

        // Buttons
        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            alumno = (Alumno)this.txtDni.Text;
            alumno.Nombre = this.txtNombre.Text;
            alumno.Apellido = this.txtApellido.Text;
            this.lstAlumnosCreados.Items.Add(alumno);
        }

        private void btnAsignarMateria_Click(object sender, EventArgs e)
        {
            EMateria materia = (EMateria)this.cbMaterias.SelectedItem;
            string mensaje = string.Empty;
            if (materia == EMateria.Programacion)
            {
                mensaje = cursoProgramacion.InscribirAlumno((Alumno)alumno);
            }
            else
            {
                mensaje = cursoLaboratorio.InscribirAlumno((Alumno)alumno);
            }
            this.lstAlumnosCreados.Items.Remove(alumno);
            MessageBox.Show(mensaje, "Incripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ActualizarInscriptos();
        }

        private void ActualizarInscriptos()
        {
            this.lstAlumnosInscriptosLaboratorio.DataSource = null;
            this.lstAlumnosInscriptosProgramacion.DataSource = null;
            this.lstAlumnosInscriptosLaboratorio.DataSource = this.cursoLaboratorio.Alumnos;
            this.lstAlumnosInscriptosProgramacion.DataSource = this.cursoProgramacion.Alumnos;
        }
    }
}