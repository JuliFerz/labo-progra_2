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

            // Ejercicios 23
            //Application.Run(new Conversor());

            // Ejercicios 24
            Application.Run(new Temperatura());
        }
    }
}