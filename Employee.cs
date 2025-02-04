using System;

class Employee
{
    private static string CompanyName = "Capgemini";
    private static int totalEmployees = 0;
    private readonly int Id;
    private string Name;
    private string Designation;

    public Employee(int Id, string Name, string Designation)
    {
        this.Id = Id;
        this.Name = Name;
        this.Designation = Designation;
        totalEmployees++;
    }

    public void DisplayEmployeeDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("Employee ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Designation: " + Designation);
        }
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }
}

class Program
{
    static void Main(String[] args)
    {
        Employee emp1 = new Employee(1, "Vinay Pal", "Software Engineer");
		Employee emp2 = new Employee(2, "Shivansh", "Software Engineer");
        emp1.DisplayEmployeeDetails();
		emp2.DisplayEmployeeDetails();
        
        Employee.DisplayTotalEmployees();
    }
}
