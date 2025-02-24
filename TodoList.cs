using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Implement login functionality", "Omendra", "HIGH")]
    public void LoginFeature()
    {
        Console.WriteLine("Login feature implementation.");
    }

    [Todo("Create database schema", "John")]
    public void DatabaseSchema()
    {
        Console.WriteLine("Database schema design.");
    }

    [Todo("Add API documentation", "Alice", "LOW")]
    public void ApiDocs()
    {
        Console.WriteLine("API documentation.");
    }
}

class Program
{
    static void Main()
    {
        Project project = new Project();

        MethodInfo[] methods = typeof(Project).GetMethods();
        foreach (MethodInfo method in methods)
        {
            object[] todos = method.GetCustomAttributes(typeof(TodoAttribute), false);
            foreach (TodoAttribute todo in todos)
            {
                Console.WriteLine("Task: " + todo.Task + ", Assigned To: " + todo.AssignedTo + ", Priority: " + todo.Priority);
            }
        }
    }
}