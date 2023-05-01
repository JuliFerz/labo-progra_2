namespace _05_Ejercicios_forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Ejercicio I02
            Application.Run(new Registro());

            // Ejercicio 23
            //Application.Run(new Conversor());

            // Ejercicio 24
            //Application.Run(new Temperatura());
        }
    }
}