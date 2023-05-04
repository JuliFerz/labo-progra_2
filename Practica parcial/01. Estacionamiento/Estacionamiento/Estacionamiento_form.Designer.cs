namespace FRM_Estacionamiento
{
    partial class Estacionamiento_form
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
            lblTipoVehiculo = new Label();
            lblPatente = new Label();
            lblTipo = new Label();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            lstVehiculos = new ListBox();
            btnAgregar = new Button();
            txtNombreEstacionamiento = new TextBox();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoVehiculo.Location = new Point(39, 54);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(106, 21);
            lblTipoVehiculo.TabIndex = 0;
            lblTipoVehiculo.Text = "Tipo Vehiculo:";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatente.Location = new Point(39, 104);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(64, 21);
            lblPatente.TabIndex = 1;
            lblPatente.Text = "Patente:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(39, 156);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(122, 21);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Elija un vehículo";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(169, 52);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 3;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(169, 154);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(121, 23);
            cmbTipoMoto.TabIndex = 4;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(169, 102);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(121, 23);
            txtPatente.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(309, 154);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 23);
            txtMarca.TabIndex = 7;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(436, 119);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(283, 259);
            lstVehiculos.TabIndex = 8;
            lstVehiculos.DoubleClick += lstVehiculos_DoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(39, 331);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 47);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar Vehículo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.Location = new Point(436, 52);
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(283, 23);
            txtNombreEstacionamiento.TabIndex = 10;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(295, 331);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(126, 47);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Estacionamiento_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 400);
            Controls.Add(btnBorrar);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(btnAgregar);
            Controls.Add(lstVehiculos);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(lblTipo);
            Controls.Add(lblPatente);
            Controls.Add(lblTipoVehiculo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Estacionamiento_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento Julian Fernandez";
            Load += Estacionamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoVehiculo;
        private Label lblPatente;
        private Label lblTipo;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private ListBox lstVehiculos;
        private Button btnAgregar;
        private TextBox txtNombreEstacionamiento;
        private Button btnBorrar;
    }
}