using System;

class EmployeeRecord
{
    public int employeeID;     // Public: Accessible anywhere
    protected string department; // Protected: Accessible in subclass
    private double salary;     // Private: Only accessible within the class

    // Constructor
    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    // Public method to update salary
    public void UpdateSalary(double newSalary)
    {
        if (newSalary > 0)
        {
            salary = newSalary;
            Console.WriteLine("Salary updated to: " + salary);
        }
    }

    // Public method to get salary
    public double GetSalary()
    {
        return salary;
    }
}

// Subclass demonstrating access to employeeID and department
class Manager : Employee
{
    private string role;

    public Manager(int employeeID, string department, double salary, string role)
        : base(employeeID, department, salary)
    {
        this.role = role;
    }

    public void DisplayManager()
    {
        Console.WriteLine("Employee ID: " + employeeID + ", Department: " + department + ", Role: " + role);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Employee emp = new Employee(2001, "IT", 60000);
        emp.UpdateSalary(65000);
        Console.WriteLine("Current Salary: " + emp.GetSalary());

        Manager mgr = new Manager(2002, "HR", 75000, "HR Head");
        mgr.DisplayManager();
    }
}
