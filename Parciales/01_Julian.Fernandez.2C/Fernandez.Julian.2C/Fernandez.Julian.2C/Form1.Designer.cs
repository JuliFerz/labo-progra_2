namespace Fernandez.Julian._2C
{
    partial class Inscripcion
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
            gbAltaAlumno = new GroupBox();
            btnCrearAlumno = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            gbAsignarMateria = new GroupBox();
            btnAsignarMateria = new Button();
            lblMateria = new Label();
            cbMaterias = new ComboBox();
            lblAlumnosCreados = new Label();
            lblInscriptosProgra = new Label();
            lblInscriptosLabo = new Label();
            lstAlumnosCreados = new ListBox();
            lstAlumnosInscriptosProgra = new ListBox();
            lstAlumnosInscriptosLabo = new ListBox();
            gbAltaAlumno.SuspendLayout();
            gbAsignarMateria.SuspendLayout();
            SuspendLayout();
            // 
            // gbAltaAlumno
            // 
            gbAltaAlumno.Controls.Add(btnCrearAlumno);
            gbAltaAlumno.Controls.Add(textBox3);
            gbAltaAlumno.Controls.Add(textBox2);
            gbAltaAlumno.Controls.Add(textBox1);
            gbAltaAlumno.Controls.Add(lblDni);
            gbAltaAlumno.Controls.Add(lblApellido);
            gbAltaAlumno.Controls.Add(lblNombre);
            gbAltaAlumno.Location = new Point(209, 12);
            gbAltaAlumno.Name = "gbAltaAlumno";
            gbAltaAlumno.Size = new Size(360, 194);
            gbAltaAlumno.TabIndex = 0;
            gbAltaAlumno.TabStop = false;
            gbAltaAlumno.Text = "Alta Alumno";
            // 
            // btnCrearAlumno
            // 
            btnCrearAlumno.Location = new Point(124, 152);
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.Size = new Size(111, 28);
            btnCrearAlumno.TabIndex = 15;
            btnCrearAlumno.Text = "Crear Alumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(241, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 9;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(6, 35);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(33, 17);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(124, 35);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 17);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "APELLIDO:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(241, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 17);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "NOMBRE:";
            // 
            // gbAsignarMateria
            // 
            gbAsignarMateria.Controls.Add(btnAsignarMateria);
            gbAsignarMateria.Controls.Add(lblMateria);
            gbAsignarMateria.Controls.Add(cbMaterias);
            gbAsignarMateria.Location = new Point(212, 275);
            gbAsignarMateria.Name = "gbAsignarMateria";
            gbAsignarMateria.Size = new Size(237, 198);
            gbAsignarMateria.TabIndex = 1;
            gbAsignarMateria.TabStop = false;
            gbAsignarMateria.Text = "Asignar Materia";
            // 
            // btnAsignarMateria
            // 
            btnAsignarMateria.Location = new Point(43, 147);
            btnAsignarMateria.Name = "btnAsignarMateria";
            btnAsignarMateria.Size = new Size(144, 45);
            btnAsignarMateria.TabIndex = 0;
            btnAsignarMateria.Text = "Asignar al alumno seleccionado";
            btnAsignarMateria.UseVisualStyleBackColor = true;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateria.Location = new Point(85, 26);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(60, 17);
            lblMateria.TabIndex = 6;
            lblMateria.Text = "MATERIA";
            // 
            // cbMaterias
            // 
            cbMaterias.FormattingEnabled = true;
            cbMaterias.Location = new Point(55, 46);
            cbMaterias.Name = "cbMaterias";
            cbMaterias.Size = new Size(121, 23);
            cbMaterias.TabIndex = 15;
            // 
            // lblAlumnosCreados
            // 
            lblAlumnosCreados.AutoSize = true;
            lblAlumnosCreados.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlumnosCreados.Location = new Point(12, 255);
            lblAlumnosCreados.Name = "lblAlumnosCreados";
            lblAlumnosCreados.Size = new Size(111, 17);
            lblAlumnosCreados.TabIndex = 5;
            lblAlumnosCreados.Text = "Alumnos Creados";
            // 
            // lblInscriptosProgra
            // 
            lblInscriptosProgra.AutoSize = true;
            lblInscriptosProgra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInscriptosProgra.Location = new Point(459, 255);
            lblInscriptosProgra.Name = "lblInscriptosProgra";
            lblInscriptosProgra.Size = new Size(111, 17);
            lblInscriptosProgra.TabIndex = 7;
            lblInscriptosProgra.Text = "Inscriptos Progra:";
            // 
            // lblInscriptosLabo
            // 
            lblInscriptosLabo.AutoSize = true;
            lblInscriptosLabo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInscriptosLabo.Location = new Point(667, 255);
            lblInscriptosLabo.Name = "lblInscriptosLabo";
            lblInscriptosLabo.Size = new Size(100, 17);
            lblInscriptosLabo.TabIndex = 8;
            lblInscriptosLabo.Text = "Inscriptos Labo:";
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            lstAlumnosCreados.ItemHeight = 15;
            lstAlumnosCreados.Location = new Point(12, 275);
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            lstAlumnosCreados.Size = new Size(192, 214);
            lstAlumnosCreados.TabIndex = 12;
            // 
            // lstAlumnosInscriptosProgra
            // 
            lstAlumnosInscriptosProgra.FormattingEnabled = true;
            lstAlumnosInscriptosProgra.ItemHeight = 15;
            lstAlumnosInscriptosProgra.Location = new Point(459, 275);
            lstAlumnosInscriptosProgra.Name = "lstAlumnosInscriptosProgra";
            lstAlumnosInscriptosProgra.Size = new Size(192, 214);
            lstAlumnosInscriptosProgra.TabIndex = 13;
            // 
            // lstAlumnosInscriptosLabo
            // 
            lstAlumnosInscriptosLabo.FormattingEnabled = true;
            lstAlumnosInscriptosLabo.ItemHeight = 15;
            lstAlumnosInscriptosLabo.Location = new Point(667, 275);
            lstAlumnosInscriptosLabo.Name = "lstAlumnosInscriptosLabo";
            lstAlumnosInscriptosLabo.Size = new Size(192, 214);
            lstAlumnosInscriptosLabo.TabIndex = 14;
            // 
            // Inscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 520);
            Controls.Add(lstAlumnosInscriptosLabo);
            Controls.Add(lstAlumnosInscriptosProgra);
            Controls.Add(lstAlumnosCreados);
            Controls.Add(lblInscriptosLabo);
            Controls.Add(lblInscriptosProgra);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(gbAsignarMateria);
            Controls.Add(gbAltaAlumno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Inscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripcion alumnos";
            gbAltaAlumno.ResumeLayout(false);
            gbAltaAlumno.PerformLayout();
            gbAsignarMateria.ResumeLayout(false);
            gbAsignarMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbAltaAlumno;
        private Button btnCrearAlumno;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private GroupBox gbAsignarMateria;
        private Label lblMateria;
        private Label lblAlumnosCreados;
        private Label lblInscriptosProgra;
        private Label lblInscriptosLabo;
        private ListBox lstAlumnosCreados;
        private ListBox lstAlumnosInscriptosProgra;
        private ListBox lstAlumnosInscriptosLabo;
        private ComboBox cbMaterias;
        private Button btnAsignarMateria;
    }
}