using System;

class TemperatureConverter
{
    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Function to take input from the user
    static void GetInput(out double temperature, out string scale)
    {
        Console.WriteLine("Enter the temperature value:");
        temperature = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the scale you want to convert from (C for Celsius, F for Fahrenheit):");
        scale = Console.ReadLine().Trim().ToUpper();

        // Validate scale input
        while (scale != "C" && scale != "F")
        {
            Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit:");
            scale = Console.ReadLine().Trim().ToUpper();
        }
    }

    // Function to display the result
    static void DisplayResult(double originalTemp, string originalScale, double convertedTemp, string targetScale)
    {
        Console.WriteLine(originalTemp + "°" + originalScale + " is equal to " + convertedTemp.ToString("F2") + "°" + targetScale);
    }

    static void Main(string[] args)
    {
        // Get input from the user
        double temperature;
        string scale;
        GetInput(out temperature, out scale);

        // Perform conversion and display the result
        if (scale == "C")
        {
            double result = CelsiusToFahrenheit(temperature);
            DisplayResult(temperature, "C", result, "F");
        }
        else if (scale == "F")
        {
            double result = FahrenheitToCelsius(temperature);
            DisplayResult(temperature, "F", result, "C");
        }
    }
}
