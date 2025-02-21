using System;

class Program
{
    static void Method1()
    {
        throw new ArithmeticException("Division by zero attempt");
    }

    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
