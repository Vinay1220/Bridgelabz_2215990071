using System;

// Utility class to handle unit conversions for distance
public static class UnitConvertor
{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Method to convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}

// Main program to test distance conversions
class Program
{
    static void Main(string[] args)
    {
        // Testing the UnitConvertor methods
        double kilometers = 10.0;
        double miles = UnitConvertor.ConvertKmToMiles(kilometers);
        Console.WriteLine("10 kilometers is equal to " + miles + " miles.");

        double feet = 328.084;
        double meters = UnitConvertor.ConvertFeetToMeters(feet);
        Console.WriteLine("328.084 feet is equal to " + meters + " meters.");
    }
}
