namespace _05_Ejercicios_forms
{
    partial class Registro
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
            gbDetallesUsuario = new GroupBox();
            numEdad = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            gbGeneros = new GroupBox();
            rbOtro = new RadioButton();
            rbFemenino = new RadioButton();
            rbMasculino = new RadioButton();
            gbCursos = new GroupBox();
            chkJavaScript = new CheckBox();
            chkCPlusPlus = new CheckBox();
            chkCSharp = new CheckBox();
            lbPaises = new ListBox();
            label4 = new Label();
            btnIngresar = new Button();
            gbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            gbGeneros.SuspendLayout();
            gbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gbDetallesUsuario
            // 
            gbDetallesUsuario.AccessibleName = "Detalles del usuario";
            gbDetallesUsuario.Controls.Add(numEdad);
            gbDetallesUsuario.Controls.Add(label3);
            gbDetallesUsuario.Controls.Add(label2);
            gbDetallesUsuario.Controls.Add(label1);
            gbDetallesUsuario.Controls.Add(txtDireccion);
            gbDetallesUsuario.Controls.Add(txtNombre);
            gbDetallesUsuario.Location = new Point(27, 30);
            gbDetallesUsuario.Name = "gbDetallesUsuario";
            gbDetallesUsuario.Size = new Size(222, 142);
            gbDetallesUsuario.TabIndex = 0;
            gbDetallesUsuario.TabStop = false;
            gbDetallesUsuario.Text = "Detalles del usuario";
            // 
            // numEdad
            // 
            numEdad.Location = new Point(80, 88);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(114, 23);
            numEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Dirección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(80, 55);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(114, 23);
            txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 23);
            txtNombre.TabIndex = 0;
            // 
            // gbGeneros
            // 
            gbGeneros.AccessibleName = "Género";
            gbGeneros.Controls.Add(rbOtro);
            gbGeneros.Controls.Add(rbFemenino);
            gbGeneros.Controls.Add(rbMasculino);
            gbGeneros.Location = new Point(291, 30);
            gbGeneros.Name = "gbGeneros";
            gbGeneros.Size = new Size(137, 105);
            gbGeneros.TabIndex = 1;
            gbGeneros.TabStop = false;
            gbGeneros.Text = "Género";
            // 
            // rbOtro
            // 
            rbOtro.AutoSize = true;
            rbOtro.Location = new Point(18, 72);
            rbOtro.Name = "rbOtro";
            rbOtro.Size = new Size(87, 19);
            rbOtro.TabIndex = 11;
            rbOtro.TabStop = true;
            rbOtro.Text = "Helicóptero";
            rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(18, 47);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(78, 19);
            rbFemenino.TabIndex = 10;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(18, 22);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 9;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            gbCursos.AccessibleName = "Curso";
            gbCursos.Controls.Add(chkJavaScript);
            gbCursos.Controls.Add(chkCPlusPlus);
            gbCursos.Controls.Add(chkCSharp);
            gbCursos.Location = new Point(291, 145);
            gbCursos.Name = "gbCursos";
            gbCursos.Size = new Size(137, 100);
            gbCursos.TabIndex = 1;
            gbCursos.TabStop = false;
            gbCursos.Text = "Cursos";
            // 
            // chkJavaScript
            // 
            chkJavaScript.AutoSize = true;
            chkJavaScript.Location = new Point(13, 72);
            chkJavaScript.Name = "chkJavaScript";
            chkJavaScript.Size = new Size(78, 19);
            chkJavaScript.TabIndex = 2;
            chkJavaScript.Text = "JavaScript";
            chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCPlusPlus
            // 
            chkCPlusPlus.AutoSize = true;
            chkCPlusPlus.Location = new Point(13, 47);
            chkCPlusPlus.Name = "chkCPlusPlus";
            chkCPlusPlus.Size = new Size(50, 19);
            chkCPlusPlus.TabIndex = 1;
            chkCPlusPlus.Text = "C++";
            chkCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(13, 22);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(41, 19);
            chkCSharp.TabIndex = 0;
            chkCSharp.Text = "C#";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // lbPaises
            // 
            lbPaises.AccessibleName = "País";
            lbPaises.FormattingEnabled = true;
            lbPaises.ItemHeight = 15;
            lbPaises.Location = new Point(27, 200);
            lbPaises.Name = "lbPaises";
            lbPaises.Size = new Size(222, 109);
            lbPaises.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 182);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "País";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(321, 274);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(107, 35);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 330);
            Controls.Add(btnIngresar);
            Controls.Add(label4);
            Controls.Add(lbPaises);
            Controls.Add(gbGeneros);
            Controls.Add(gbCursos);
            Controls.Add(gbDetallesUsuario);
            Name = "Registro";
            Text = "Registro";
            gbDetallesUsuario.ResumeLayout(false);
            gbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            gbGeneros.ResumeLayout(false);
            gbGeneros.PerformLayout();
            gbCursos.ResumeLayout(false);
            gbCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDetallesUsuario;
        private GroupBox gbGeneros;
        private GroupBox gbCursos;
        private NumericUpDown numEdad;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private RadioButton rbOtro;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private CheckBox chkJavaScript;
        private CheckBox chkCPlusPlus;
        private CheckBox chkCSharp;
        private ListBox lbPaises;
        private Label label4;
        private Button btnIngresar;
    }
}