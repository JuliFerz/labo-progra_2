using Fernandez.Julian._2C;

namespace FRM_Estacionamiento
{
    public partial class Estacionamiento_form : Form
    {
        private Estacionamiento estacionamiento;
        public Estacionamiento_form()
        {
            InitializeComponent();
        }

        private void Estacionamiento_Load(object sender, EventArgs e)
        {
            this.cmbTipoVehiculo.DataSource = Enum.GetValues(typeof(Vehiculo.EVehiculos));
            this.cmbTipoMoto.DataSource = Enum.GetValues(typeof(Moto.ETipo));
            this.estacionamiento = Estacionamiento.GetEstacionamiento("Julian Fernandez", 3);
            this.txtNombreEstacionamiento.Text = this.estacionamiento.Nombre;
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Vehiculo.EVehiculos)this.cmbTipoVehiculo.SelectedItem == Vehiculo.EVehiculos.Automovil)
            {
                this.cmbTipoMoto.Visible = false;
                lblTipo.Text = "Marca:";
                this.txtMarca.Location = this.cmbTipoMoto.Location;
                this.txtMarca.Visible = true;
            }
            else
            {
                this.cmbTipoMoto.Visible = true;
                lblTipo.Text = "Tipo Moto:";
                this.txtMarca.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo;
            if ((Vehiculo.EVehiculos)this.cmbTipoVehiculo.SelectedItem == Vehiculo.EVehiculos.Automovil)
            {
                vehiculo = new Automovil(this.txtPatente.Text, DateTime.Now, this.txtMarca.Text);
            }
            else
            {
                vehiculo = new Moto(this.txtPatente.Text, DateTime.Now, (Moto.ETipo)this.cmbTipoMoto.SelectedItem);
            }

            if (vehiculo.Patente is null)
            {
                MessageBox.Show($"Patente inválida: {this.txtPatente.Text}\n* Entre 6 a 7 caracteres", "Error de patente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.estacionamiento + vehiculo)
            {
                this.lstVehiculos.Items.Add(vehiculo);
                MessageBox.Show(vehiculo.ToString(), "Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al asignar el vehículo\n* Espacio del estaciomamiento lleno", "Error de cupos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstVehiculos_DoubleClick(object sender, EventArgs e)
        {
            if (this.estacionamiento - (Vehiculo)this.lstVehiculos.SelectedItem)
            {
                MessageBox.Show(
                    this.estacionamiento.InformarSalida((Vehiculo)this.lstVehiculos.SelectedItem),
                    "Ingreso al Estacionamiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.lstVehiculos.Items.Remove((Vehiculo)this.lstVehiculos.SelectedItem);
            }
        }

        /* Nueva funcionalidad de prueba */
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!(this.lstVehiculos.SelectedItem is null) && this.estacionamiento - (Vehiculo)this.lstVehiculos.SelectedItem)
            {
                MessageBox.Show($"Vehiculo eliminado: {this.estacionamiento.InformarSalida((Vehiculo)this.lstVehiculos.SelectedItem)}");
                this.lstVehiculos.Items.Remove((Vehiculo)this.lstVehiculos.SelectedItem);
            }
        }
    }
}