using Entidades.DataBase;
using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;


namespace Entidades.Modelos
{
    public delegate void DelegadoDemoraAtencion(double demora);
    public delegate void DelegadoNuevoIngreso(IComestible menu);
    public class Cocinero<T> where T : IComestible, new()
    {
        public event DelegadoDemoraAtencion OnDemora;
        public event DelegadoNuevoIngreso OnIngreso;

        private int cantPedidosFinalizados;
        private string nombre;
        private double demoraPreparacionTotal;
        private CancellationTokenSource cancellation;
        private T menu;
        private Task tarea;

        public bool HabilitarCocina
        {
            get
            {
                return this.tarea is not null
                    && (this.tarea.Status == TaskStatus.Running
                    || this.tarea.Status == TaskStatus.WaitingToRun
                    || this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.HabilitarCocina)
                {
                    this.cancellation = new CancellationTokenSource();
                    this.IniciarIngreso();
                }
                else
                {
                    this.cancellation.Cancel();
                }
            }
        }
        public double TiempoMedioDePreparacion { get => this.cantPedidosFinalizados == 0 ? 0 : this.demoraPreparacionTotal / this.cantPedidosFinalizados; }
        public string Nombre { get => nombre; }
        public int CantPedidosFinalizados { get => this.cantPedidosFinalizados; }

        public Cocinero(string nombre)
        {
            this.nombre = nombre;
            this.demoraPreparacionTotal = 0;
        }

        private void IniciarIngreso()
        {
            this.tarea = Task.Run(() =>
            {
                while (!this.cancellation.IsCancellationRequested)
                {
                    this.NotificarNuevoIngreso();
                    this.EsperarProximoIngreso();
                    this.cantPedidosFinalizados++;
                    DataBaseManager.GuardarTicket(this.nombre, this.menu);
                }
            });
        }

        private void NotificarNuevoIngreso()
        {
            if (this.OnIngreso is not null)
            {
                this.menu = new T();
                this.menu.IniciarPreparacion();
                this.OnIngreso.Invoke(this.menu);
            }
        }
        private void EsperarProximoIngreso()
        {
            if (this.OnDemora is not null)
            {
                int i = 0;
                while (!this.cancellation.IsCancellationRequested
                    && !this.menu.Estado)
                {
                    Thread.Sleep(1000);
                    this.OnDemora.Invoke(i++);
                }
                this.demoraPreparacionTotal += TiempoMedioDePreparacion;
            }
        }
    }
}
