using System;

class CalculatorUsingSwitch
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter an operator (+, -, *, /):");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;
            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;
            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine("Result: " + (first / second));
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
