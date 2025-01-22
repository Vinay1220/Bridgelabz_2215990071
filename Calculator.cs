using System;

class Calculator
{
    static void Main()
    {
        // Variables for the two numbers
        double number1, number2;

        // Input for the two numbers
        Console.WriteLine("Enter the first number:");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2; 

        // Output
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + number1 + " and " + number2 + " is " + addition + ", " + subtraction + ", " + multiplication + ", and " + division);
    }
}
