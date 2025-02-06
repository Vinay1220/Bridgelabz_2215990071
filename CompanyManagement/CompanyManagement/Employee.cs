namespace CompanyManagement
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(int employeeId, string name, string position)
        {
            EmployeeId = employeeId;
            Name = name;
            Position = position;
        }
    }
}
