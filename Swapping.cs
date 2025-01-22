using System;

class Swapping
{
    static void Main()
    {
        // Variables for numbers
        double number1, number2, temp;

        // Input for two numbers
        Console.WriteLine("Enter the first number:");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        number2 = Convert.ToDouble(Console.ReadLine());

        // Swapping the numbers
        temp = number1;
        number1 = number2;
        number2 = temp;

        // Output the swapped numbers
        Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
    }
}
