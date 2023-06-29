using Azure;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Entidades
{
    public class DBManager
    {
        static string stringConnection = ConfigurationManager.ConnectionStrings["myConnection"].ToString();

        public static List<Cliente> GetClientes(string table)
        {
            List<Cliente> listaEmpleados = new List<Cliente>();

            using (SqlConnection connection = new SqlConnection(DBManager.stringConnection))
            {
                string query = $"SELECT * FROM {table}";
                SqlCommand cmd = new SqlCommand(query, connection); // Genera el comando usando sentencia en la conexión
                connection.Open(); // abrir conexión SQL
                SqlDataReader reader = cmd.ExecuteReader(); // para operaciones de lectura

                while (reader.Read()) // mientras siga leyendo de la BD (read devuelve un booleano)
                {
                    listaEmpleados.Add(new Cliente(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetInt32(4),
                        reader.GetString(5),
                        0
                    ));
                }
                return listaEmpleados;
            }
        }

        public static Cliente GetClientePorId(string table, int id)
        {
            using (SqlConnection connection = new SqlConnection(DBManager.stringConnection))
            {
                string query = $"SELECT * FROM {table} WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Cliente(reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetInt32(4),
                        reader.GetString(5),
                        0);
                }
                throw new Exception("No se encontró empleado con esa ID");
            }
        }
        public static int InsertCliente(Cliente cliente)
        {
            using (SqlConnection connection = new SqlConnection(DBManager.stringConnection))
            {
                string query = "INSERT INTO CLIENTS (NAME, SECOND_NAME, SURNAME, AGE, EMAIL) VALUES (@NAME, @SECOND_NAME, @SURNAME, @AGE, @EMAIL)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("NAME", cliente.Name);
                if (cliente.SecondName is not null)
                    cmd.Parameters.AddWithValue("SECOND_NAME", cliente.SecondName);
                cmd.Parameters.AddWithValue("SURNAME", cliente.SurName);
                cmd.Parameters.AddWithValue("AGE", cliente.Age);
                cmd.Parameters.AddWithValue("EMAIL", cliente.Email);
                connection.Open();

                return cmd.ExecuteNonQuery(); // ejecuta la sentencia
            }
        }
    }
}