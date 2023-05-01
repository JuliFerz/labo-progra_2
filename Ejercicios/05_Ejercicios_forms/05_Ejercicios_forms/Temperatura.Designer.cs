namespace _05_Ejercicios_forms
{
    partial class Temperatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            txtFahrenheit = new TextBox();
            txtCelsius = new TextBox();
            txtKelvin = new TextBox();
            txtKelvinToFahrenheit = new TextBox();
            txtCelsiusToFahrenheit = new TextBox();
            txtFahrenheitToFahrenheit = new TextBox();
            txtKelvinToCelsius = new TextBox();
            txtCelsiusToCelsius = new TextBox();
            txtFahrenheitToCelsius = new TextBox();
            txtKelvinToKelvin = new TextBox();
            txtCelsiusToKelvin = new TextBox();
            txtFahrenheitToKelvin = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnConvertFahrenheit = new Button();
            btnConvertCelsius = new Button();
            btnConvertKelvin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 41);
            label1.Margin = new Padding(3, 0, 3, 18);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 80);
            label2.Margin = new Padding(3, 0, 3, 18);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 0;
            label2.Text = "Celsius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 119);
            label3.Margin = new Padding(3, 0, 3, 18);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 0;
            label3.Text = "Kelvin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(404, 15);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 3;
            label6.Text = "Fahrenheit";
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.AccessibleName = "Temperatura Fahrenheit";
            txtFahrenheit.Location = new Point(190, 39);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(100, 23);
            txtFahrenheit.TabIndex = 1;
            txtFahrenheit.Leave += txtFahrenheit_Leave;
            // 
            // txtCelsius
            // 
            txtCelsius.AccessibleName = "Temperatura Celsius";
            txtCelsius.Location = new Point(190, 78);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 2;
            txtCelsius.Leave += txtCelsius_Leave;
            // 
            // txtKelvin
            // 
            txtKelvin.AccessibleName = "Temperatura Kelvin";
            txtKelvin.Location = new Point(190, 117);
            txtKelvin.Name = "txtKelvin";
            txtKelvin.Size = new Size(100, 23);
            txtKelvin.TabIndex = 3;
            txtKelvin.Leave += txtKelvin_Leave;
            // 
            // txtKelvinToFahrenheit
            // 
            txtKelvinToFahrenheit.Enabled = false;
            txtKelvinToFahrenheit.Location = new Point(399, 117);
            txtKelvinToFahrenheit.Name = "txtKelvinToFahrenheit";
            txtKelvinToFahrenheit.Size = new Size(100, 23);
            txtKelvinToFahrenheit.TabIndex = 5;
            // 
            // txtCelsiusToFahrenheit
            // 
            txtCelsiusToFahrenheit.Enabled = false;
            txtCelsiusToFahrenheit.Location = new Point(399, 78);
            txtCelsiusToFahrenheit.Name = "txtCelsiusToFahrenheit";
            txtCelsiusToFahrenheit.Size = new Size(100, 23);
            txtCelsiusToFahrenheit.TabIndex = 6;
            // 
            // txtFahrenheitToFahrenheit
            // 
            txtFahrenheitToFahrenheit.Enabled = false;
            txtFahrenheitToFahrenheit.Location = new Point(399, 39);
            txtFahrenheitToFahrenheit.Name = "txtFahrenheitToFahrenheit";
            txtFahrenheitToFahrenheit.Size = new Size(100, 23);
            txtFahrenheitToFahrenheit.TabIndex = 7;
            // 
            // txtKelvinToCelsius
            // 
            txtKelvinToCelsius.Enabled = false;
            txtKelvinToCelsius.Location = new Point(505, 117);
            txtKelvinToCelsius.Name = "txtKelvinToCelsius";
            txtKelvinToCelsius.Size = new Size(100, 23);
            txtKelvinToCelsius.TabIndex = 8;
            // 
            // txtCelsiusToCelsius
            // 
            txtCelsiusToCelsius.Enabled = false;
            txtCelsiusToCelsius.Location = new Point(505, 78);
            txtCelsiusToCelsius.Name = "txtCelsiusToCelsius";
            txtCelsiusToCelsius.Size = new Size(100, 23);
            txtCelsiusToCelsius.TabIndex = 9;
            // 
            // txtFahrenheitToCelsius
            // 
            txtFahrenheitToCelsius.Enabled = false;
            txtFahrenheitToCelsius.Location = new Point(505, 39);
            txtFahrenheitToCelsius.Name = "txtFahrenheitToCelsius";
            txtFahrenheitToCelsius.Size = new Size(100, 23);
            txtFahrenheitToCelsius.TabIndex = 10;
            // 
            // txtKelvinToKelvin
            // 
            txtKelvinToKelvin.Enabled = false;
            txtKelvinToKelvin.Location = new Point(611, 117);
            txtKelvinToKelvin.Name = "txtKelvinToKelvin";
            txtKelvinToKelvin.Size = new Size(100, 23);
            txtKelvinToKelvin.TabIndex = 11;
            // 
            // txtCelsiusToKelvin
            // 
            txtCelsiusToKelvin.Enabled = false;
            txtCelsiusToKelvin.Location = new Point(611, 78);
            txtCelsiusToKelvin.Name = "txtCelsiusToKelvin";
            txtCelsiusToKelvin.Size = new Size(100, 23);
            txtCelsiusToKelvin.TabIndex = 12;
            // 
            // txtFahrenheitToKelvin
            // 
            txtFahrenheitToKelvin.Enabled = false;
            txtFahrenheitToKelvin.Location = new Point(611, 39);
            txtFahrenheitToKelvin.Name = "txtFahrenheitToKelvin";
            txtFahrenheitToKelvin.Size = new Size(100, 23);
            txtFahrenheitToKelvin.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(521, 15);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 3;
            label4.Text = "Celsius";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(628, 15);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 3;
            label5.Text = "Kelvin";
            // 
            // btnConvertFahrenheit
            // 
            btnConvertFahrenheit.Location = new Point(296, 39);
            btnConvertFahrenheit.Name = "btnConvertFahrenheit";
            btnConvertFahrenheit.Size = new Size(97, 23);
            btnConvertFahrenheit.TabIndex = 4;
            btnConvertFahrenheit.Text = "->";
            btnConvertFahrenheit.UseVisualStyleBackColor = true;
            btnConvertFahrenheit.Click += btnConvertFahrenheit_Click;
            // 
            // btnConvertCelsius
            // 
            btnConvertCelsius.Location = new Point(296, 77);
            btnConvertCelsius.Name = "btnConvertCelsius";
            btnConvertCelsius.Size = new Size(97, 23);
            btnConvertCelsius.TabIndex = 5;
            btnConvertCelsius.Text = "->";
            btnConvertCelsius.UseVisualStyleBackColor = true;
            btnConvertCelsius.Click += btnConvertCelsius_Click;
            // 
            // btnConvertKelvin
            // 
            btnConvertKelvin.Location = new Point(296, 116);
            btnConvertKelvin.Name = "btnConvertKelvin";
            btnConvertKelvin.Size = new Size(97, 23);
            btnConvertKelvin.TabIndex = 6;
            btnConvertKelvin.Text = "->";
            btnConvertKelvin.UseVisualStyleBackColor = true;
            btnConvertKelvin.Click += btnConvertKelvin_Click;
            // 
            // Temperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 184);
            Controls.Add(btnConvertKelvin);
            Controls.Add(btnConvertCelsius);
            Controls.Add(btnConvertFahrenheit);
            Controls.Add(txtKelvinToKelvin);
            Controls.Add(txtCelsiusToKelvin);
            Controls.Add(txtFahrenheitToKelvin);
            Controls.Add(txtKelvinToCelsius);
            Controls.Add(txtCelsiusToCelsius);
            Controls.Add(txtFahrenheitToCelsius);
            Controls.Add(txtKelvinToFahrenheit);
            Controls.Add(txtCelsiusToFahrenheit);
            Controls.Add(txtFahrenheitToFahrenheit);
            Controls.Add(txtKelvin);
            Controls.Add(txtCelsius);
            Controls.Add(txtFahrenheit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Temperatura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor temperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txtFahrenheit;
        private TextBox txtCelsius;
        private TextBox txtKelvin;
        private TextBox txtKelvinToFahrenheit;
        private TextBox txtCelsiusToFahrenheit;
        private TextBox txtFahrenheitToFahrenheit;
        private TextBox txtKelvinToCelsius;
        private TextBox txtCelsiusToCelsius;
        private TextBox txtFahrenheitToCelsius;
        private TextBox txtKelvinToKelvin;
        private TextBox txtCelsiusToKelvin;
        private TextBox txtFahrenheitToKelvin;
        private Label label4;
        private Label label5;
        private Button btnConvertFahrenheit;
        private Button btnConvertCelsius;
        private Button btnConvertKelvin;
    }
}