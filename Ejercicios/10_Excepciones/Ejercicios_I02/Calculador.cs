using Entidades.Exceptions;
using Entidades.Models;

namespace Ejercicios_I02
{
    public partial class Calculador : Form
    {
        public Calculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 1;
                this.CheckParameters();
                float division = ClaseCalculador.Calcular(int.Parse(this.txtKilometros.Text), int.Parse(this.txtLitros.Text));
                this.rtbTexto.AppendText($"� [{i}] La division dio: {Math.Round(division,2)}\n");
                i++;
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show($"[ERROR]: {ex.Message}", "Error en campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"[ERROR]: El formato de entrada no es v�lido\nDetalle: {ex.Message}", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show($"[ERROR]: No se puede dividir por un numero con 0\nDetalle: {ex.Message}", "Error en division", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// M�todo para chequear que los parametros de entrada del usuario no sean nulos o vac�os
        /// </summary>
        /// <exception cref="ParametrosVaciosException">Excepci�n que busca si algunos datos est�n vac�os o nulos</exception>
        private void CheckParameters()
        {
            if (string.IsNullOrEmpty(this.txtKilometros.Text)
                  || string.IsNullOrEmpty(this.txtLitros.Text))
            {
                throw new ParametrosVaciosException("Parametros de entrada vac�os");
            }
        }
    }
}