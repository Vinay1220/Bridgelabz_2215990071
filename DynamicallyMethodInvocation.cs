using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class ReflectionExample
{
    static void Main()
    {
        MathOperations mathOperations = new MathOperations();

        Console.WriteLine("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        Type type = typeof(MathOperations);

        MethodInfo method = type.GetMethod(methodName);

        if (method != null)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            object result = method.Invoke(mathOperations, new object[] { num1, num2 });

            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}