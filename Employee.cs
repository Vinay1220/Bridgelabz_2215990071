using System;

class Employee
{
    // Attributes
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    // Constructor to initialize attributes
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: " + Salary.ToString("C"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Take input from the user
        Console.WriteLine("Enter Employee Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Employee ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employee Salary:");
        double salary = double.Parse(Console.ReadLine());

        // Create an Employee object
        Employee emp = new Employee(name, id, salary);

        // Display employee details
        emp.DisplayDetails();
    }
}
