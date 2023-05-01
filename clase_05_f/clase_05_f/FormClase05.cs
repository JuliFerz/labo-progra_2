using Entidades;

namespace clase_05_f
{
    public partial class FormClase05 : Form
    {
        Persona p;
        public FormClase05()
        {
            InitializeComponent();

            //this.btnAceptar.Text = "El botón ahora cambió el nombre";
            this.lstBox.Items.Add("Test");
            p = new Persona();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Hola mundo", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show(resultado.ToString()); // devuelve "OK" o "Cancel" según se haga click
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("La operación fue OK");
            }


            MessageBox.Show($"{this.txtApellido.Text.ToUpper()}, {this.txtNombre.Text}", "Caja de texto", MessageBoxButtons.OK);
            SegundoForm segundoForm = new SegundoForm(); // genero una instancia del nuevo formulario
            //segundoForm.Opacity = 0.85F;
            DialogResult result = segundoForm.ShowDialog(); // Si dejo "Show" en vez de "showDialog", puedo abrir n cant de formularios.
                                                            // Para evitar esto, usamos showDialog (no permite interactuar con el
                                                            // primer form hasta que no se cierre el segundo abierto)


            //segundoForm.GetPalabra();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Todo OK!"); // aparece si se cierra el formulario
            }

            // recorrer groupbox
            //this.grpDatos.Controls Todos los controles del group grpDatos
            //rhis.Controls TODOS los controles
            foreach (Control item in this.grpDatos.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name == "txtNombre")
                    {
                        item.Text = "lalala";
                    }
                }
            }

        }

        private void FormClase05_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing) // completo
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //e.Cancel = true; // hace que no se pueda cerrar con la X de arriba a la derecha
                // porque estoy cancelando la ejecución de este evento antes de que se cierre (FormClosing)
                DialogResult resultado = MessageBox.Show("Desea cerrar la ventana?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No) // Si el usuario pone que no (no cerrar ventana), se cancela el evento de closing (no se cierra)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}