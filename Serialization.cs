using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static string filePath = "employees.json";

    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 70000 }
        };

        SerializeEmployees(employees);
        List<Employee> deserializedEmployees = DeserializeEmployees();
        DisplayEmployees(deserializedEmployees);
    }

    static void SerializeEmployees(List<Employee> employees)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Employees serialized successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static List<Employee> DeserializeEmployees()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Employee data file does not exist.");
                return new List<Employee>();
            }
            
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(jsonString) ?? new List<Employee>();
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            return new List<Employee>();
        }
    }

    static void DisplayEmployees(List<Employee> employees)
    {
        Console.WriteLine("\nEmployee List:");
        foreach (var emp in employees)
        {
            Console.WriteLine("ID: " + emp.Id + ", Name: " + emp.Name + ", Department: " + emp.Department + ", Salary: " + emp.Salary);
        }
    }
}
