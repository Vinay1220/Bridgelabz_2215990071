using System;

class BasicCalculator
{
    // Function to perform addition
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Function to perform subtraction
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Function to perform multiplication
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Function to perform division
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; // Return "Not a Number" if division by zero
        }
        return a / b;
    }

    // Function to get input from the user
    static void GetInput(out double a, out double b)
    {
        Console.WriteLine("Enter the first number:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        b = double.Parse(Console.ReadLine());
    }

    // Function to display the menu and return the user's choice
    static char DisplayMenu()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("Enter your choice (1/2/3/4):");

        char choice = Console.ReadLine()[0];
        return choice;
    }

    // Main function to handle the flow of the program
    static void Main(string[] args)
    {
        char choice = DisplayMenu();

        // Get inputs from the user
        double num1, num2;
        GetInput(out num1, out num2);

        // Perform the selected operation
        switch (choice)
        {
            case '1':
                Console.WriteLine("Result: " + Add(num1, num2));
                break;
            case '2':
                Console.WriteLine("Result: " + Subtract(num1, num2));
                break;
            case '3':
                Console.WriteLine("Result: " + Multiply(num1, num2));
                break;
            case '4':
                Console.WriteLine("Result: " + Divide(num1, num2));
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid operation.");
                break;
        }
    }
}
