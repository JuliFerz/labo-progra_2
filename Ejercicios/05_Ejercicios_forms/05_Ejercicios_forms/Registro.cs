using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro;

namespace _05_Ejercicios_forms
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

            this.lbPaises.Items.Add("Argentina");
            this.lbPaises.Items.Add("Chile");
            this.lbPaises.Items.Add("Uruguay");
        }

        // Button
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!this.CheckAllFields())
            {
                List<string> cursos = this.GetCourses(this.gbCursos);
                string genero = this.GetGenero(this.gbGeneros);
                string pais = this.lbPaises.SelectedItem.ToString();

                Ingresante ingresante = new Ingresante(
                    nombre: this.txtNombre.Text,
                    direccion: this.txtDireccion.Text,
                    genero: genero,
                    pais: pais,
                    cursos: cursos.ToArray(),
                    edad: (int)this.numEdad.Value
                );
                MessageBox.Show($"Datos del ingresante:{ingresante.Mostrar()}", "Datos");
            }

        }

        // Methods
        private bool CheckAllFields()
        {
            bool checkedFields = false;
            if (this.CheckUserDetails())
            {
                checkedFields = true;
                this.ErrorMsg(this.gbDetallesUsuario, "Por favor carge los datos del usuario.");
            }
            else if (this.CheckUserCountry())
            {
                checkedFields = true;
                this.ErrorMsg(this.lbPaises, "Por favor seleccione un pais.");
            }
            else if (this.CheckUserGenre())
            {
                checkedFields = true;
                this.ErrorMsg(this.gbGeneros, "Por favor elija un genero");
            }
            else if (this.CheckUserCourses())
            {
                checkedFields = true;
                this.ErrorMsg(this.gbCursos, "Por favor elija uno (o varios) curso/s.");
            }

            return checkedFields;
        }
        private bool CheckUserDetails()
        {
            return (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtDireccion.Text) || this.numEdad.Value == 0)
                    ? true
                    : false;
        }
        private bool CheckUserCountry()
        {
            return this.lbPaises.SelectedItems.Count == 0 ? true : false;
        }
        private bool CheckUserGenre()
        {
            return !(this.rbMasculino.Checked || this.rbFemenino.Checked || this.rbOtro.Checked) ? true : false;
        }
        private bool CheckUserCourses()
        {
            return !(this.chkCPlusPlus.Checked || this.chkCSharp.Checked || this.chkJavaScript.Checked) ? true : false;
        }

        private List<string> GetCourses(Control control)
        {
            List<string> strings = new List<string>();
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Checked)
                {
                    strings.Add(c.Text);
                }
            }
            return strings;
        }

        private string GetGenero(Control control)
        {
            string genre = "";
            foreach (Control c in control.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                {
                    genre = c.Text;
                    break;
                }
            }
            return genre;
        }

        private void ErrorMsg(Control control, string msg = "")
        {
            MessageBox.Show($"Error al validar: {control.AccessibleName}\n{msg}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
