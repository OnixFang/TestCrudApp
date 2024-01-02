using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace TestCrudApp.DAL
{
    public static class SynergiesDb
    {
        static readonly MySqlConnection connection = new(ConfigurationManager.ConnectionStrings["synergiesDb"].ConnectionString);

        public static DataTable GetEmployees()
        {
            using (MySqlCommand cmd = new("sp_get_employees", connection))
            {
                try
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adapter = new(cmd);
                    DataTable dataTable = new();
                    adapter.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
                catch (MySqlException)
                {
                    throw;
                }
            }
        }
    }
}
