using System.Data.SqlClient;

namespace Entidades
{
    public class DBManager
    {
        static string stringConnection = "Server=.;Database=clase_15;Trusted_Connection=True;";

        // traemos todos los empleados
        public static List<Empleado> GetEmpleados()
        {
            // metodo manual
            //SqlConnection connection = new SqlConnection(DBManager.stringConnection);
            //connection.Open();
            //connection.Close();

            List<Empleado> employeeList = new List<Empleado>(); // si la lista está adentro, el return que esta dentro del using hay que pasarlo afuera del using
            using (SqlConnection connection = new SqlConnection(DBManager.stringConnection))
            {

                string query = "SELECT * FROM EMPLEADOS";
                SqlCommand cmd = new SqlCommand(query, connection); // Genera el comando usando sentencia en la conexión

                connection.Open(); // abrimos la conexión a la BD

                SqlDataReader reader = cmd.ExecuteReader(); // para operaciones de lectura
                //cmd.ExecuteNonQuery(); // Para casos donde se genera un tipo de sentencia de tipo DELETE, UPDATE o INSERT
                                         // Es decir, todas que no sean de lectura
                
                while(reader.Read()) // mientras siga leyendo de la BD (read devuelve un booleano)
                {
                    // reader se puede indexar, por lo que se puede colocar entre corchetes con el nombre exacto de la columna
                    // O se puede indexar por enteros 21.03
                    //employeeList.Add(new Empleado(reader["ID"], reader["Nombre"], reader["Apellido"], reader["ID_SECTOR"]));

                    // otra forma:
                    // Se usa getstring o geting según el tipo de dato de la BD
                    employeeList.Add(new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                }
                return employeeList; // retornamos dentro del using? va por dentro del using porque 
                                     // el código entra si o si en el using
            }
            //return employeeList; // retornamos la lista de empleados
        }

        // traemos UN SOLO EMPLEADO
        public static Empleado GetEmpleado(int employeeId)
        {
            using (SqlConnection connection = new SqlConnection(DBManager.stringConnection))
            {

                string query = "SELECT * FROM EMPLEADOS WHERE ID = @employeeId";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", employeeId); // 

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                                                           
                                                           

                while (reader.Read()) // mientras siga leyendo de la BD (read devuelve un booleano)
                {
                    return new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                }
                throw new Exception("No existe un empleado con ese ID");
            }
        }

        // Metodo para INSERTAR empleado en la base
        public static int InsertEmpleado(Empleado empleado)
        {
            using (SqlConnection connection = new SqlConnection(DBManager.stringConnection))
            {
                string query = "INSERT INTO EMPLEADOS (NOMBRE;APELLIDO;ID_SECTOR) SET (@nombre, @apellido, @idSector)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("idSector", empleado.IdSector);
                connection.Open();

                return cmd.ExecuteNonQuery(); // ejecutamos la sentencia de arriba
            }
        }
    }
}