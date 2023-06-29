namespace View
{
    public partial class View<T> : Form 
        where T : class
    {
        public View()
        {
            InitializeComponent();
            int y = 0;
            foreach (var propiedad in typeof(T).GetProperties()) // Recorremos las propiedades de Persona (dni, nombre, apellido y fechanacimiento)
            {
                Label label = new Label(); // genera instancia de control
                label.Name = propiedad.Name; // se le asigna un name al label
                label.Text = propiedad.Name + ":"; // se le asigna un texto (lo que se muestra en form)
                label.Location = new Point(0, y); // se instancia una posición en el formulario
                this.Controls.Add(label); // se añade el label a la colección de controles
                y += 20; // se desplaza Y para que el prox. label se genere abajo
            }
        }
    }
}