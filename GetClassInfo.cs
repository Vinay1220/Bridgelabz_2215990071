using System;
using System.Reflection;

class ReflectionExample
{
    static void Main()
    {
        Console.WriteLine("Enter the fully qualified class name: ");
        string className = Console.ReadLine();

        try
        {
            Type type = Type.GetType(className);

            if (type == null)
            {
                Console.WriteLine("Class not found. Ensure the namespace is included.");
                return;
            }

            Console.WriteLine("Class: " + type.FullName);

            Console.WriteLine("Constructors:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor);
            }

            Console.WriteLine("Fields:");
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field);
            }

            Console.WriteLine("Methods:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}