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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
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
            lstAlumnosInscriptosProgramacion = new ListBox();
            lstAlumnosInscriptosLaboratorio = new ListBox();
            gbAltaAlumno.SuspendLayout();
            gbAsignarMateria.SuspendLayout();
            SuspendLayout();
            // 
            // gbAltaAlumno
            // 
            gbAltaAlumno.Controls.Add(btnCrearAlumno);
            gbAltaAlumno.Controls.Add(txtNombre);
            gbAltaAlumno.Controls.Add(txtApellido);
            gbAltaAlumno.Controls.Add(txtDni);
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
            btnCrearAlumno.Click += btnCrearAlumno_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(241, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(111, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(124, 58);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(111, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(6, 58);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(111, 23);
            txtDni.TabIndex = 9;
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
            btnAsignarMateria.Click += btnAsignarMateria_Click;
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
            // lstAlumnosInscriptosProgramacion
            // 
            lstAlumnosInscriptosProgramacion.FormattingEnabled = true;
            lstAlumnosInscriptosProgramacion.ItemHeight = 15;
            lstAlumnosInscriptosProgramacion.Location = new Point(459, 275);
            lstAlumnosInscriptosProgramacion.Name = "lstAlumnosInscriptosProgramacion";
            lstAlumnosInscriptosProgramacion.Size = new Size(192, 214);
            lstAlumnosInscriptosProgramacion.TabIndex = 13;
            // 
            // lstAlumnosInscriptosLaboratorio
            // 
            lstAlumnosInscriptosLaboratorio.FormattingEnabled = true;
            lstAlumnosInscriptosLaboratorio.ItemHeight = 15;
            lstAlumnosInscriptosLaboratorio.Location = new Point(667, 275);
            lstAlumnosInscriptosLaboratorio.Name = "lstAlumnosInscriptosLaboratorio";
            lstAlumnosInscriptosLaboratorio.Size = new Size(192, 214);
            lstAlumnosInscriptosLaboratorio.TabIndex = 14;
            // 
            // Inscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 520);
            Controls.Add(lstAlumnosInscriptosLaboratorio);
            Controls.Add(lstAlumnosInscriptosProgramacion);
            Controls.Add(lstAlumnosCreados);
            Controls.Add(lblInscriptosLabo);
            Controls.Add(lblInscriptosProgra);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(gbAsignarMateria);
            Controls.Add(gbAltaAlumno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Inscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripcion alumnos";
            Load += Inscripcion_Load;
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
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private GroupBox gbAsignarMateria;
        private Label lblMateria;
        private Label lblAlumnosCreados;
        private Label lblInscriptosProgra;
        private Label lblInscriptosLabo;
        private ListBox lstAlumnosCreados;
        private ListBox lstAlumnosInscriptosProgramacion;
        private ListBox lstAlumnosInscriptosLaboratorio;
        private ComboBox cbMaterias;
        private Button btnAsignarMateria;
    }
}