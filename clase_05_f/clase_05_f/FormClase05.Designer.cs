namespace clase_05_f
{
    partial class FormClase05
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
            btnAceptar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            grpDatos = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            lstBox = new ListBox();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(282, 38);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(236, 60);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Abrir Segundo Form";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escriba aquí...";
            txtNombre.Size = new Size(237, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(249, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Escriba aquí...";
            txtApellido.Size = new Size(237, 23);
            txtApellido.TabIndex = 1;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(txtApellido);
            grpDatos.Location = new Point(140, 228);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(553, 197);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 23);
            label2.Name = "label2";
            label2.Size = new Size(240, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido ──────────────────────────────┐";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(240, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre ──────────────────────────────┐";
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.ItemHeight = 15;
            lstBox.Location = new Point(592, 78);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(196, 94);
            lstBox.TabIndex = 3;
            // 
            // FormClase05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBox);
            Controls.Add(grpDatos);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormClase05";
            Text = "Formulario Clase05";
            FormClosing += FormClase05_FormClosing;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private GroupBox grpDatos;
        private ListBox lstBox;
        private Label label1;
        private Label label2;
    }
}