using System.Data;
using TestCrudApp.DAL;

namespace TestCrudApp.BLL
{
    public static class SynergiesLogic
    {
        public static DataTable GetEmployees()
        {
            return SynergiesDb.GetEmployees();
        }
    }
}
