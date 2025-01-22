using System;

class TempInCelsius
{
    static void Main()
    {
        // Variable for temperature in Fahrenheit
        double fahrenheit, celsiusResult;

        // Input for the temperature in Fahrenheit
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert Fahrenheit to Celsius using the formula
        celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Output
        Console.WriteLine(fahrenheit + " Fahrenheit is " + celsiusResult + " Celsius");
    }
}
