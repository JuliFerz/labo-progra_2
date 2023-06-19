using Entidades;
using System.Configuration;

namespace clase_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<Empleado> listaEmpleados = DBManager.GetEmpleados();
            foreach (Empleado emp in listaEmpleados)
            {
                Console.WriteLine(emp.Nombre);
            }

            // traer el apellido del empleado de la DB cuyo ID es 1
            Console.WriteLine(DBManager.GetEmpleado(1).Apellido);


            // Añadimos un empleado a la DB (21.28)
            DBManager.InsertEmpleado(new Empleado("Manteca", "Paulina", 123));*/

            Console.WriteLine(ConfigurationManager.AppSettings["saludo"]);
            Console.WriteLine(ConfigurationManager.ConnectionStrings["myConnection"]);
        }
    }
}