using System;

class Program1
{
    static void Main()
    {
        // Variables for the two numbers
        int number1, number2;

        // Input for the two numbers
        Console.WriteLine("Enter the first number:");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        number2 = Convert.ToInt32(Console.ReadLine());

        // Calculate quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Output
        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
    }
}
