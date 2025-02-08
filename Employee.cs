using System;

// Base class (Superclass)
public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Virtual method to be overridden in subclasses
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: " + Salary);
    }
}

// Subclass Manager
public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

// Subclass Developer
public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}

// Subclass Intern
public class Intern : Employee
{
    public string InternshipDuration { get; set; }

    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + InternshipDuration);
    }
}

// Main class to test polymorphism
public class Program
{
    public static void Main()
    {
        Employee emp1 = new Manager("Vinay", 101, 75000, 5);
        Employee emp2 = new Developer("Boby", 102, 60000, "C#");
        Employee emp3 = new Intern("Shakshi", 103, 20000, "6 months");

        emp1.DisplayDetails();
        Console.WriteLine();
        emp2.DisplayDetails();
        Console.WriteLine();
        emp3.DisplayDetails();
    }
}
