namespace _05_Ejercicios_forms
{
    partial class Conversor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEuro = new TextBox();
            txtPeso = new TextBox();
            txtDolar = new TextBox();
            txtEURtoEUR = new TextBox();
            txtARStoEUR = new TextBox();
            txtARStoUSD = new TextBox();
            txtEURtoUSD = new TextBox();
            txtARStoARS = new TextBox();
            txtEURtoARS = new TextBox();
            txtCotizEuro = new TextBox();
            txtCotizPeso = new TextBox();
            txtCotizDolar = new TextBox();
            btnEuro = new Button();
            btnPeso = new Button();
            btnDolar = new Button();
            btnCandado = new Button();
            imlCandado = new ImageList(components);
            panelCotiz = new Panel();
            txtUSDtoUSD = new TextBox();
            txtUSDtoARS = new TextBox();
            txtUSDtoEUR = new TextBox();
            panelCotiz.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 17);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Cotización";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 167);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Peso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 122);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 3;
            label4.Text = "Dólar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 75);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Euro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(354, 49);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 7;
            label2.Text = "Euro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(457, 49);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 6;
            label6.Text = "Dólar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(563, 49);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 5;
            label7.Text = "Peso";
            // 
            // txtEuro
            // 
            txtEuro.AccessibleName = "Euro";
            txtEuro.Location = new Point(108, 77);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 8;
            txtEuro.Leave += txtEuro_Leave;
            // 
            // txtPeso
            // 
            txtPeso.AccessibleName = "Peso";
            txtPeso.Location = new Point(108, 169);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 9;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // txtDolar
            // 
            txtDolar.AccessibleName = "Dolar";
            txtDolar.Location = new Point(108, 124);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 10;
            txtDolar.Leave += txtDolar_Leave;
            // 
            // txtEURtoEUR
            // 
            txtEURtoEUR.Enabled = false;
            txtEURtoEUR.Location = new Point(332, 77);
            txtEURtoEUR.Name = "txtEURtoEUR";
            txtEURtoEUR.ReadOnly = true;
            txtEURtoEUR.Size = new Size(100, 23);
            txtEURtoEUR.TabIndex = 11;
            // 
            // txtARStoEUR
            // 
            txtARStoEUR.Enabled = false;
            txtARStoEUR.Location = new Point(332, 169);
            txtARStoEUR.Name = "txtARStoEUR";
            txtARStoEUR.ReadOnly = true;
            txtARStoEUR.Size = new Size(100, 23);
            txtARStoEUR.TabIndex = 12;
            // 
            // txtARStoUSD
            // 
            txtARStoUSD.Enabled = false;
            txtARStoUSD.Location = new Point(438, 169);
            txtARStoUSD.Name = "txtARStoUSD";
            txtARStoUSD.ReadOnly = true;
            txtARStoUSD.Size = new Size(100, 23);
            txtARStoUSD.TabIndex = 15;
            // 
            // txtEURtoUSD
            // 
            txtEURtoUSD.Enabled = false;
            txtEURtoUSD.Location = new Point(438, 76);
            txtEURtoUSD.Name = "txtEURtoUSD";
            txtEURtoUSD.ReadOnly = true;
            txtEURtoUSD.Size = new Size(100, 23);
            txtEURtoUSD.TabIndex = 14;
            // 
            // txtARStoARS
            // 
            txtARStoARS.Enabled = false;
            txtARStoARS.Location = new Point(544, 169);
            txtARStoARS.Name = "txtARStoARS";
            txtARStoARS.ReadOnly = true;
            txtARStoARS.Size = new Size(100, 23);
            txtARStoARS.TabIndex = 18;
            // 
            // txtEURtoARS
            // 
            txtEURtoARS.Enabled = false;
            txtEURtoARS.Location = new Point(544, 76);
            txtEURtoARS.Name = "txtEURtoARS";
            txtEURtoARS.ReadOnly = true;
            txtEURtoARS.Size = new Size(100, 23);
            txtEURtoARS.TabIndex = 17;
            // 
            // txtCotizEuro
            // 
            txtCotizEuro.AccessibleName = "Cotizacion Euro";
            txtCotizEuro.Location = new Point(0, 0);
            txtCotizEuro.Name = "txtCotizEuro";
            txtCotizEuro.Size = new Size(100, 23);
            txtCotizEuro.TabIndex = 20;
            txtCotizEuro.Leave += txtCotizEuro_Leave;
            // 
            // txtCotizPeso
            // 
            txtCotizPeso.AccessibleName = "Cotizacion Peso";
            txtCotizPeso.Location = new Point(216, 0);
            txtCotizPeso.Name = "txtCotizPeso";
            txtCotizPeso.Size = new Size(100, 23);
            txtCotizPeso.TabIndex = 21;
            txtCotizPeso.Leave += txtCotizPeso_Leave;
            // 
            // txtCotizDolar
            // 
            txtCotizDolar.AccessibleName = "Cotizacion Dolar";
            txtCotizDolar.Location = new Point(110, 0);
            txtCotizDolar.Name = "txtCotizDolar";
            txtCotizDolar.Size = new Size(100, 23);
            txtCotizDolar.TabIndex = 22;
            txtCotizDolar.Text = "1";
            txtCotizDolar.Leave += txtCotizDolar_Leave;
            // 
            // btnEuro
            // 
            btnEuro.Location = new Point(214, 78);
            btnEuro.Name = "btnEuro";
            btnEuro.Size = new Size(102, 23);
            btnEuro.TabIndex = 26;
            btnEuro.Text = "->";
            btnEuro.UseVisualStyleBackColor = true;
            btnEuro.Click += btnEuro_Click;
            // 
            // btnPeso
            // 
            btnPeso.Location = new Point(214, 169);
            btnPeso.Name = "btnPeso";
            btnPeso.Size = new Size(102, 23);
            btnPeso.TabIndex = 27;
            btnPeso.Text = "->";
            btnPeso.UseVisualStyleBackColor = true;
            btnPeso.Click += btnPeso_Click;
            // 
            // btnDolar
            // 
            btnDolar.Location = new Point(214, 124);
            btnDolar.Name = "btnDolar";
            btnDolar.Size = new Size(102, 23);
            btnDolar.TabIndex = 28;
            btnDolar.Text = "->";
            btnDolar.UseVisualStyleBackColor = true;
            btnDolar.Click += btnDolar_Click;
            // 
            // btnCandado
            // 
            btnCandado.ImageIndex = 0;
            btnCandado.ImageList = imlCandado;
            btnCandado.Location = new Point(222, 12);
            btnCandado.Name = "btnCandado";
            btnCandado.Size = new Size(86, 35);
            btnCandado.TabIndex = 29;
            btnCandado.UseVisualStyleBackColor = true;
            btnCandado.Click += btnCandado_Click;
            // 
            // imlCandado
            // 
            imlCandado.ColorDepth = ColorDepth.Depth32Bit;
            imlCandado.ImageStream = (ImageListStreamer)resources.GetObject("imlCandado.ImageStream");
            imlCandado.TransparentColor = Color.Transparent;
            imlCandado.Images.SetKeyName(0, "internet_locked_padlock_password_secure_security_unlock_icon_127083.png");
            imlCandado.Images.SetKeyName(1, "internet_lock_locked_padlock_password_secure_security_icon_127078.png");
            // 
            // panelCotiz
            // 
            panelCotiz.Controls.Add(txtCotizDolar);
            panelCotiz.Controls.Add(txtCotizPeso);
            panelCotiz.Controls.Add(txtCotizEuro);
            panelCotiz.Location = new Point(332, 19);
            panelCotiz.Name = "panelCotiz";
            panelCotiz.Size = new Size(318, 28);
            panelCotiz.TabIndex = 31;
            // 
            // txtUSDtoUSD
            // 
            txtUSDtoUSD.Enabled = false;
            txtUSDtoUSD.Location = new Point(438, 122);
            txtUSDtoUSD.Name = "txtUSDtoUSD";
            txtUSDtoUSD.ReadOnly = true;
            txtUSDtoUSD.Size = new Size(100, 23);
            txtUSDtoUSD.TabIndex = 16;
            // 
            // txtUSDtoARS
            // 
            txtUSDtoARS.Enabled = false;
            txtUSDtoARS.Location = new Point(544, 122);
            txtUSDtoARS.Name = "txtUSDtoARS";
            txtUSDtoARS.ReadOnly = true;
            txtUSDtoARS.Size = new Size(100, 23);
            txtUSDtoARS.TabIndex = 19;
            // 
            // txtUSDtoEUR
            // 
            txtUSDtoEUR.Enabled = false;
            txtUSDtoEUR.Location = new Point(332, 122);
            txtUSDtoEUR.Name = "txtUSDtoEUR";
            txtUSDtoEUR.ReadOnly = true;
            txtUSDtoEUR.Size = new Size(100, 23);
            txtUSDtoEUR.TabIndex = 13;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 231);
            Controls.Add(txtARStoEUR);
            Controls.Add(txtARStoARS);
            Controls.Add(txtEURtoEUR);
            Controls.Add(txtARStoUSD);
            Controls.Add(txtEURtoARS);
            Controls.Add(txtUSDtoEUR);
            Controls.Add(txtEURtoUSD);
            Controls.Add(txtUSDtoARS);
            Controls.Add(txtUSDtoUSD);
            Controls.Add(panelCotiz);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnCandado);
            Controls.Add(btnDolar);
            Controls.Add(btnPeso);
            Controls.Add(btnEuro);
            Controls.Add(txtDolar);
            Controls.Add(txtPeso);
            Controls.Add(txtEuro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Conversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            panelCotiz.ResumeLayout(false);
            panelCotiz.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox txtEuro;
        private TextBox txtPeso;
        private TextBox txtDolar;
        private TextBox txtEURtoEUR;
        private TextBox txtARStoEUR;
        private TextBox txtARStoUSD;
        private TextBox txtEURtoUSD;
        private TextBox txtARStoARS;
        private TextBox txtEURtoARS;
        private TextBox txtCotizEuro;
        private TextBox txtCotizPeso;
        private TextBox txtCotizDolar;
        private Button btnEuro;
        private Button btnPeso;
        private Button btnDolar;
        private Button btnCandado;
        private ImageList imlCandado;
        private Panel panelCotiz;
        private TextBox txtUSDtoUSD;
        private TextBox txtUSDtoARS;
        private TextBox txtUSDtoEUR;
    }
}