using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperaturas;

namespace _05_Ejercicios_forms
{
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        // Buttons
        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFahrenheit.Text))
            {
                this.ErrorMsg(this.txtFahrenheit, "Cargue una temperatura primero");
            }
            else
            {
                Fahrenheit f = new Fahrenheit(double.Parse(this.txtFahrenheit.Text));
                this.txtFahrenheitToFahrenheit.Text = $"{f.GetTemperatura()}";
                this.txtFahrenheitToCelsius.Text = $"{((Celsius)f).GetTemperatura()}";
                this.txtFahrenheitToKelvin.Text = $"{((Kelvin)f).GetTemperatura()}";
            }
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCelsius.Text))
            {
                this.ErrorMsg(this.txtCelsius, "Cargue una temperatura primero");
            }
            else
            {
                Celsius c = new Celsius(double.Parse(this.txtCelsius.Text));
                this.txtCelsiusToFahrenheit.Text = $"{((Fahrenheit)c).GetTemperatura()}";
                this.txtCelsiusToCelsius.Text = $"{c.GetTemperatura()}";
                this.txtCelsiusToKelvin.Text = $"{((Kelvin)c).GetTemperatura()}";
            }
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtKelvin.Text))
            {
                this.ErrorMsg(this.txtKelvin, "Cargue una temperatura primero");
            }
            else
            {
                Kelvin k = new Kelvin(double.Parse(this.txtKelvin.Text));
                this.txtKelvinToFahrenheit.Text = $"{((Fahrenheit)k).GetTemperatura()}";
                this.txtKelvinToCelsius.Text = $"{((Celsius)k).GetTemperatura()}";
                this.txtKelvinToKelvin.Text = $"{k.GetTemperatura()}";
            }
        }

        // Leave
        private void txtFahrenheit_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFahrenheit.Text)
                && !this.ValidateTextBoxNumber(this.txtFahrenheit))
            {
                this.SetEmptyTxtBox(this.txtFahrenheit);
                this.ErrorMsg(this.txtFahrenheit, "Cargue una temperatura válida");
            }
        }

        private void txtCelsius_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtCelsius.Text)
                && !this.ValidateTextBoxNumber(this.txtCelsius))
            {
                this.SetEmptyTxtBox(this.txtCelsius);
                this.ErrorMsg(this.txtCelsius, "Cargue una temperatura válida");
            }
        }

        private void txtKelvin_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtKelvin.Text)
                && !this.ValidateTextBoxNumber(this.txtKelvin))
            {
                this.SetEmptyTxtBox(this.txtKelvin);
                this.ErrorMsg(this.txtKelvin, "Cargue una temperatura válida");
            }
        }

        // Methods

        /// <summary>
        /// It validates if the textbox input is a number correctly
        /// </summary>
        /// <param name="txt"></param>
        /// <returns>bool</returns>
        private bool ValidateTextBoxNumber(TextBox txt)
        {
            return true ? Regex.IsMatch(txt.Text, @"^[\,0-9]+$") : false;
        }

        /// <summary>
        /// It show a messagebox to the user to mention that the operation was invalid
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="errorMsg">optional</param>
        private void ErrorMsg(TextBox txt, string errorMsg = "")
        {
            MessageBox.Show($"Operación inválida para \"{txt.AccessibleName}\"\n{errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// It sets a empty string to a textbox
        /// </summary>
        /// <param name="txt"></param>
        private void SetEmptyTxtBox(TextBox txt)
        {
            txt.Text = string.Empty;
        }

    }
}
