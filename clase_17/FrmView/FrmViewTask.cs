namespace FrmView
{
    public partial class FrmViewTask : Form
    {
        CancellationTokenSource cancellationTokenSource;
        Task tarea;
        public FrmViewTask()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            this.tarea = Task.Run(() => this.IniciarReloj(this.cancellationTokenSource), token);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }
        public delegate void Callback(int nro, string saludo);
        private void ActualizarHora(int nro, string saludo)
        {
            // consultamos si el formulario requiere invocación
            if (this.InvokeRequired) // el hilo principal necesita ser invocado?
                                     // Desde un hilo secundario, esto es TRUE, pero si invoqué al principal, es FALSE
            {
                // this.BeginInvoke(() => this.ActualizarHora(hora, saludo));
                /*
                 * A partir de acá invocamos al hilo principal (lo que necesitamos para editar un control
                 *                                              del form desde un hilo secundario)
                 * Con esto, podemos luego entonces actualizar el label
                 * Ejemplo: Es como pedirle "permiso" al hilo principal para modificarle algo de él (control).
                 */

                // Esto es lo mismo que lo de arriba (con lambda), pero dificil
                Callback callback = new Callback(this.ActualizarHora);
                object[] args = { nro, saludo }; // debe estar en el mismo orden que los parametros de la funcion
                this.BeginInvoke(callback, args);

                // o así:
                this.BeginInvoke(() => callback.Invoke(nro, saludo));

            }
            else
            {
                this.lblHora.Text = $"Quedan {nro} segundos";
                this.txtIngreso.Text = saludo;
            }
        }
        private void IniciarReloj(CancellationTokenSource cancellationTokenSource)
        {
            int nro = 10;
            do
            {
                this.ActualizarHora(nro, $"[{nro}] Hola mundo!");
                Thread.Sleep(1000);
                nro--;
                //} while (true && !cancellationTokenSource.IsCancellationRequested);
            } while (nro >= 0 && !cancellationTokenSource.IsCancellationRequested);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }
    }
}