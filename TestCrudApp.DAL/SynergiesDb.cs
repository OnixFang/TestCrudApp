using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using TestCrudApp.Entities;

namespace TestCrudApp.DAL
{
    public static class SynergiesDb
    {
        static readonly MySqlConnection connection = new(ConfigurationManager.ConnectionStrings["synergiesDb"].ConnectionString);

        public static DataTable GetEmployees()
        {
            using (MySqlCommand command = new("sp_get_employees", connection))
            {
                try
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adapter = new(command);
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

        public static DataTable SearchEmployee(string employeeName)
        {
            using (MySqlCommand command = new("sp_search_employee", connection))
            {
                try
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@term", employeeName);
                    MySqlDataAdapter adapter = new(command);
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

        public static string AddEmployee(Employee newEmployee)
        {
            using (MySqlCommand command = new("sp_maintain_employee", connection))
            {
                try
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@v_id", 0);
                    command.Parameters.AddWithValue("@v_name", newEmployee.EmployeeName);
                    command.Parameters.AddWithValue("@v_age", newEmployee.EmployeeAge);
                    command.Parameters.AddWithValue("@v_phone", newEmployee.EmployeePhone);
                    command.Parameters.AddWithValue("@v_action", "CREATE");
                    command.Parameters["@v_action"].Direction = ParameterDirection.InputOutput;
                    command.ExecuteNonQuery();
                    connection.Close();
                    return command.Parameters["@v_action"].Value.ToString();
                }
                catch (MySqlException)
                {
                    throw;
                }
            }
        }

        public static string UpdateEmployee(Employee employee)
        {
            using (MySqlCommand command = new("sp_maintain_employee", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@v_id", employee.Id);
                command.Parameters.AddWithValue("@v_name", employee.EmployeeName);
                command.Parameters.AddWithValue("@v_age", employee.EmployeeAge);
                command.Parameters.AddWithValue("@v_phone", employee.EmployeePhone);
                command.Parameters.AddWithValue("@v_action", "UPDATE");
                command.Parameters["@v_action"].Direction = ParameterDirection.InputOutput;
                command.ExecuteNonQuery();
                connection.Close();
                return command.Parameters["@v_action"].Value.ToString();
            }
        }

        public static string DeleteEmployee(Employee employee)
        {
            using (MySqlCommand command = new("sp_maintain_employee", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@v_id", employee.Id);
                command.Parameters.AddWithValue("@v_name", employee.EmployeeName);
                command.Parameters.AddWithValue("@v_age", employee.EmployeeAge);
                command.Parameters.AddWithValue("@v_phone", employee.EmployeePhone);
                command.Parameters.AddWithValue("@v_action", "DELETE");
                command.Parameters["@v_action"].Direction = ParameterDirection.InputOutput;
                command.ExecuteNonQuery();
                connection.Close();
                return command.Parameters["@v_action"].Value.ToString();
            }
        }
    }
}
