using System;

class WindChillCalculator
{
    static void Main()
    {
        // Get temperature input
        Console.Write("Enter the temperature (in Fahrenheit): ");
        double temperature = double.Parse(Console.ReadLine());

        // Get wind speed input
        Console.Write("Enter the wind speed (in mph): ");
        double windSpeed = double.Parse(Console.ReadLine());

        // Calculate the wind chill
        double windChill = CalculateWindChill(temperature, windSpeed);

        // Output
        Console.WriteLine("The wind chill temperature is " + windChill + "°F for a temperature of " + temperature + "°F and wind speed of " + windSpeed + " mph.");
    }

    // Method to calculate wind chill temperature
    static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + (0.6215 * temperature) + ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));
    }
}
