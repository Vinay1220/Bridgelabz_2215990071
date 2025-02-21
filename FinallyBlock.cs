using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter the denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
