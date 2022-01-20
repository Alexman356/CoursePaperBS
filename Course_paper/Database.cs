using MySql.Data.MySqlClient;
using System.Data;

namespace CoursePaper
{
    class Database
    {
        public MySqlConnection Connection { get; } = new MySqlConnection(
            "server=localhost;" +
            "port=3306;" +
            "username=root;" +
            "password=;" +
            "database=binary_search;" +
            "SSLmode=none");

        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}