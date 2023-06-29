using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;

namespace Entidades.DataBase
{
    public static class DataBaseManager
    {
        static SqlConnection connection;
        static string stringConnection;

        static DataBaseManager()
        {
            DataBaseManager.stringConnection = "Server=.;Database=20230622SP;Trusted_Connection=True;";
        }

        public static string GetImagenComida(string tipo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseManager.stringConnection))
                {

                    string query = "SELECT * FROM comidas WHERE tipo_comida = @tipo";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("tipo", tipo);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader.GetString(2);
                    }
                    FileManager.Guardar($"Error de lectura.\nNo se encontró registro", "logs.txt", true);
                    throw new ComidaInvalidaException("No se encontró registro");
                }
            }
            catch (ComidaInvalidaException ex)
            {
                FileManager.Guardar($"Error de lectura.\nNo se pudo leer el tipo de comida {tipo} de la tabla de comidas", "logs.txt", true); // revisar
                throw new ComidaInvalidaException($"No se pudo leer el tipo de comida {tipo} de la tabla de comidas");
            }
        }

        public static bool GuardarTicket<T>(string nombreEmpleado, T comida)
            where T : IComestible, new()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string query = "INSERT INTO tickets (empleado, ticket) VALUES (@nombreEmpleado, @ticket)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("nombreEmpleado", nombreEmpleado);
                    cmd.Parameters.AddWithValue("ticket", comida.Ticket);
                    connection.Open();
                
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(DataBaseManagerException ex)
            {
                FileManager.Guardar($"Error de escritura.\n{ex.Message}", "logs.txt", true);
                throw new DataBaseManagerException($"No se pudo guardar el ticket {comida.Ticket} en la tabla de tickets");
            }
        }
    }
}
