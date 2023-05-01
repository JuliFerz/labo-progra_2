using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_05_f
{
    public partial class SegundoForm : Form
    {
        public SegundoForm()
        {
            InitializeComponent();
        }
        public SegundoForm(int edad)
        {

        }

        private void SegundoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.DialogResult = DialogResult.OK;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.No;
            }
        }

        public string GetPalabra()
        {
            return "Hola mundo!";
        }
    }
}
