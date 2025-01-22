using System;

class DistanceConverter
{
    static void Main(string[] args)
    {
        // Distance in kilometers
        double kilometers = 10.8;

        // Conversion factor
        double conversionFactor = 1.6;

        // Convert to miles
        double miles = kilometers / conversionFactor;

        // Output the result
        Console.WriteLine("The distance " + kilometers + " km in miles is " + miles);
    }
}
