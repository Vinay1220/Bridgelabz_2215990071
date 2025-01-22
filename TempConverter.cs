using System;

class TempConverter
{
    static void Main()
    {
        // Variable for temperature in Celsius
        double celsius, fahrenheitResult;

        // Input for the temperature in Celsius
        Console.WriteLine("Enter the temperature in Celsius:");
        celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the formula
        fahrenheitResult = (celsius * 9 / 5) + 32;

        // Output
        Console.WriteLine(celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
    }
}
