namespace TestCrudApp.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeePhone { get; set; }


        public Employee(string name, int age, string phone)
        {
            EmployeeName = name;
            EmployeeAge = age;
            EmployeePhone = phone;
        }

        public Employee(int id, string name, int age, string phone)
        {
            Id = id;
            EmployeeName = name;
            EmployeeAge = age;
            EmployeePhone = phone;
        }
    }
}
