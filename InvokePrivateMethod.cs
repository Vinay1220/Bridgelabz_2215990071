using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class ReflectionExample
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (method != null)
        {
            object result = method.Invoke(calculator, new object[] { 5, 10 });

            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}