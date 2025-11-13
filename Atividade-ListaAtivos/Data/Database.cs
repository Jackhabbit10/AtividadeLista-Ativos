using MySql.Data.MySqlClient;

namespace Atividade_ListaAtivos.Data
{
    public class Database
    {
        private readonly string connectionString = "server=localhost;port=3306;database=bdClientes;user=root;password=12345678;";



        public MySqlConnection GetConnection()

        {

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            return conn;

        }
    }
}
