using Entidades;

namespace clase_15_db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaClientes = DBManager.GetClientes("CLIENTS");

            foreach (var item in listaClientes)
            {
                Console.WriteLine(item.Name);
            }

            // INSERT INTO VALUES
            //Cliente cliente = new Cliente("Julian", "", "Fernandez", 22, "test@test.com", 0);
            //DBManager.InsertCliente(cliente);
        }
    }
}