using Entidades;

namespace clase_18
{
    public partial class FrmView : Form
    {
        Mensaje msj;
        public FrmView()
        {
            InitializeComponent();
            this.msj = new Mensaje();
            this.msj.OnMensaje += ManejarMensaje; // agregamos un manejador. Agrega una referencia a un metodo que ejecuta la acción 19.04
            this.msj.OnMensaje += ManejarMensaje2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.button1.clic
            this.msj.Saludar();
        }

        private void ManejarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void ManejarMensaje2(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje 2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}