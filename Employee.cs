using System;
using System.Collections.Generic;

// Abstract class Employee
abstract class Employee
{
    private int employeeId;
    private string name;
    protected double baseSalary;

    public int EmployeeId { get { return employeeId; } }
    public string Name { get { return name; } }

    public Employee(int id, string empName, double salary)
    {
        employeeId = id;
        name = empName;
        baseSalary = salary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine("ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + CalculateSalary());
    }
}

// Interface for department details
interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}

// Full-time employee
class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }

    public override double CalculateSalary()
    {
        return baseSalary;
    }

    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + department;
    }
}

// Part-time employee
class PartTimeEmployee : Employee, IDepartment
{
    private double hourlyRate;
    private int hoursWorked;
    private string department;

    public PartTimeEmployee(int id, string name, double hourlyRate, int hoursWorked)
        : base(id, name, 0)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }

    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + department;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        FullTimeEmployee emp1 = new FullTimeEmployee(1, "Vinay", 5000);
        emp1.AssignDepartment("IT");

        PartTimeEmployee emp2 = new PartTimeEmployee(2, "Rajesh", 20, 80);
        emp2.AssignDepartment("HR");

        employees.Add(emp1);
        employees.Add(emp2);

        foreach (Employee emp in employees)
{
		emp.DisplayDetails();

		if (emp is IDepartment)
		{
			IDepartment dept = (IDepartment)emp;
			Console.WriteLine(dept.GetDepartmentDetails());
		}

		Console.WriteLine("----------------------");
}

    }
}
