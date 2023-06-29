using System.Text.RegularExpressions;
using Moneda;

namespace _05_Ejercicios_forms
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        // btns
        private void btnCandado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCotizEuro.Text) || string.IsNullOrEmpty(this.txtCotizPeso.Text))
            {
                MessageBox.Show($"Cargue todas las cotizaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.btnCandado.ImageIndex == 0)
                {
                    this.btnCandado.ImageIndex++;
                    this.ChangeStatusTextBoxes(this.panelCotiz, false);
                }
                else
                {
                    this.btnCandado.ImageIndex--;
                    this.ChangeStatusTextBoxes(this.panelCotiz, true);
                }
            }
        }
        private void btnPeso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPeso.Text))
            {
                this.ErrorMsg(this.txtPeso, "Cargue un importe.");
            }
            else if (this.btnCandado.ImageIndex == 0)
            {
                this.ErrorMsg(this.txtPeso, "Cierre la cotización primero.");
            }
            else
            {
                Pesos ars = new Pesos(double.Parse(this.txtPeso.Text));
                this.txtARStoEUR.Text = $"{((Euro)ars).GetCantidad()}";
                this.txtARStoUSD.Text = $"{((Dolar)ars).GetCantidad()}";
                this.txtARStoARS.Text = $"{ars.GetCantidad()}";
            }
        }
        private void btnEuro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtEuro.Text))
            {
                this.ErrorMsg(this.txtEuro, "Cargue un importe.");
            }
            else if (this.btnCandado.ImageIndex == 0)
            {
                this.ErrorMsg(this.txtEuro, "Cierre la cotización primero.");
            }
            else
            {
                Euro eur = new Euro(double.Parse(this.txtEuro.Text));
                this.txtEURtoEUR.Text = $"{eur.GetCantidad()}";
                this.txtEURtoUSD.Text = $"{((Dolar)eur).GetCantidad()}";
                this.txtEURtoARS.Text = $"{((Pesos)eur).GetCantidad()}";
            }
        }
        private void btnDolar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtEuro.Text))
            {
                this.ErrorMsg(this.txtEuro, "Cargue un importe.");
            }
            else if (this.btnCandado.ImageIndex == 0)
            {
                this.ErrorMsg(this.txtEuro, "Cierre la cotización primero.");
            }
            else
            {
                Dolar usd = new Dolar(double.Parse(this.txtEuro.Text));
                this.txtUSDtoEUR.Text = $"{((Euro)usd).GetCantidad()}";
                this.txtUSDtoUSD.Text = $"{usd.GetCantidad()}";
                this.txtUSDtoARS.Text = $"{((Pesos)usd).GetCantidad()}";
            }
        }


        // leave event
        private void txtCotizDolar_Leave(object sender, EventArgs e)
        {
            if (this.txtCotizDolar.Text != "1")
            {
                this.ErrorMsg(this.txtCotizDolar);
                this.txtCotizDolar.Text = "1";
            }
        }

        private void txtCotizEuro_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtCotizEuro.Text) && !this.ValidateTextBoxNumber(this.txtCotizEuro))
            {
                this.ErrorMsg(this.txtCotizEuro);
                this.SetEmptyTxtBox(this.txtCotizEuro);
            }
            else
            {
                if (!string.IsNullOrEmpty(this.txtCotizEuro.Text))
                {
                    Euro.SetCotizacion(double.Parse(this.txtCotizEuro.Text));
                }
            }
        }
        private void txtCotizPeso_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtCotizPeso.Text) && !this.ValidateTextBoxNumber(this.txtCotizPeso))
            {
                this.ErrorMsg(this.txtCotizPeso);
                this.SetEmptyTxtBox(this.txtCotizPeso);
            }
            else
            {
                if (!string.IsNullOrEmpty(this.txtCotizPeso.Text))
                {
                    Pesos.SetCotizacion(double.Parse(this.txtCotizPeso.Text));
                }
            }
        }
        private void txtEuro_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtEuro.Text) && !this.ValidateTextBoxNumber(this.txtEuro))
            {
                this.ErrorMsg(this.txtEuro);
                this.SetEmptyTxtBox(this.txtEuro);
            }
        }
        private void txtDolar_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtDolar.Text) && !this.ValidateTextBoxNumber(this.txtDolar))
            {
                this.ErrorMsg(this.txtDolar);
                this.SetEmptyTxtBox(this.txtDolar);
            }
        }
        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPeso.Text) && !this.ValidateTextBoxNumber(this.txtPeso))
            {
                this.ErrorMsg(this.txtPeso);
                this.SetEmptyTxtBox(this.txtPeso);
            }
        }


        // methods
        private void ChangeStatusTextBoxes(Panel panelControl, bool state)
        {
            foreach (Control control in panelControl.Controls)
            {
                if (control is TextBox) { control.Enabled = state; }
            }
        }
        private bool ValidateTextBoxNumber(TextBox txt)
        {
            return true ? Regex.IsMatch(txt.Text, @"^[\,0-9]+$") : false;
        }
        private void ErrorMsg(TextBox txt, string errorMsg = "")
        {
            MessageBox.Show($"Operación inválida para \"{txt.AccessibleName}\"\n{errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SetEmptyTxtBox(TextBox txt)
        {
            txt.Text = "";
        }

    }
}