using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class MyClass
{
    [ImportantMethod("HIGH")]
    public void CriticalMethod()
    {
        Console.WriteLine("Critical method executed.");
    }

    [ImportantMethod("LOW")]
    public void RegularMethod()
    {
        Console.WriteLine("Regular method executed.");
    }

    public void NonImportantMethod()
    {
        Console.WriteLine("Non-important method executed.");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();

        MethodInfo[] methods = typeof(MyClass).GetMethods();
        foreach (MethodInfo method in methods)
        {
            ImportantMethodAttribute attribute = (ImportantMethodAttribute)Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));
            if (attribute != null)
            {
                Console.WriteLine("Method: " + method.Name + ", Importance Level: " + attribute.Level);
            }
        }
    }
}