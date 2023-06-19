namespace FrmView
{
    partial class FrmViewTask
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
            lblHora = new Label();
            btnIniciar = new Button();
            btnCancelar = new Button();
            txtIngreso = new TextBox();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(12, 9);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(158, 72);
            lblHora.TabIndex = 0;
            lblHora.Text = "Hora:";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(12, 262);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(220, 78);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(238, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 78);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(12, 84);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(446, 23);
            txtIngreso.TabIndex = 3;
            // 
            // FrmViewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 375);
            Controls.Add(txtIngreso);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(lblHora);
            Name = "FrmViewTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private Button btnIniciar;
        private Button btnCancelar;
        private TextBox txtIngreso;
    }
}