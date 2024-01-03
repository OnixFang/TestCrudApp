using System.Data;
using TestCrudApp.DAL;
using TestCrudApp.Entities;

namespace TestCrudApp.BLL
{
    public static class SynergiesLogic
    {
        public static DataTable GetEmployees()
        {
            return SynergiesDb.GetEmployees();
        }

        public static DataTable SearchEmployee(string employeeName)
        {
            return SynergiesDb.SearchEmployee(employeeName);
        }

        public static string AddEmployee(string name, int age, string phone)
        {
            Employee newEmployee = new(name, age, phone);
            return SynergiesDb.AddEmployee(newEmployee);
        }

        public static string UpdateEmployee(int id, string name, int age, string phone)
        {
            Employee employee = new(id, name, age, phone);
            return SynergiesDb.UpdateEmployee(employee);
        }

        public static string DeleteEmployee(int id, string name, int age, string phone)
        {
            Employee employee = new(id, name, age, phone);
            return SynergiesDb.DeleteEmployee(employee);
        }
    }
}
