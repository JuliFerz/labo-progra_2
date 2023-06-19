namespace Ejercicios_I02
{
    partial class Calculador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKilometros = new Label();
            lblLitros = new Label();
            txtKilometros = new TextBox();
            txtLitros = new TextBox();
            btnCalcular = new Button();
            rtbTexto = new RichTextBox();
            SuspendLayout();
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblKilometros.Location = new Point(12, 9);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(85, 21);
            lblKilometros.TabIndex = 0;
            lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            lblLitros.AutoSize = true;
            lblLitros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLitros.Location = new Point(12, 72);
            lblLitros.Name = "lblLitros";
            lblLitros.Size = new Size(49, 21);
            lblLitros.TabIndex = 1;
            lblLitros.Text = "Litros";
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(12, 33);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(164, 23);
            txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(12, 96);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(164, 23);
            txtLitros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 133);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(164, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rtbTexto
            // 
            rtbTexto.Location = new Point(245, 12);
            rtbTexto.Name = "rtbTexto";
            rtbTexto.ReadOnly = true;
            rtbTexto.Size = new Size(159, 150);
            rtbTexto.TabIndex = 5;
            rtbTexto.Text = "";
            // 
            // Calculador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 174);
            Controls.Add(rtbTexto);
            Controls.Add(btnCalcular);
            Controls.Add(txtLitros);
            Controls.Add(txtKilometros);
            Controls.Add(lblLitros);
            Controls.Add(lblKilometros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKilometros;
        private Label lblLitros;
        private TextBox txtKilometros;
        private TextBox txtLitros;
        private Button btnCalcular;
        private RichTextBox rtbTexto;
    }
}