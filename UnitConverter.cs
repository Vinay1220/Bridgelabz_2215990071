using System;

class UnitConverter
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

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the UnitConverter class
        Console.WriteLine("Unit Converter");

        // Convert kilometers to miles
        Console.Write("Enter kilometers to convert to miles: ");
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = UnitConverter.ConvertKmToMiles(km);
        Console.WriteLine($"{km} kilometers is equal to {miles} miles.");

        // Convert miles to kilometers
        Console.Write("Enter miles to convert to kilometers: ");
        double milesInput = Convert.ToDouble(Console.ReadLine());
        double kilometers = UnitConverter.ConvertMilesToKm(milesInput);
        Console.WriteLine($"{milesInput} miles is equal to {kilometers} kilometers.");

        // Convert meters to feet
        Console.Write("Enter meters to convert to feet: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        double feet = UnitConverter.ConvertMetersToFeet(meters);
        Console.WriteLine($"{meters} meters is equal to {feet} feet.");

        // Convert feet to meters
        Console.Write("Enter feet to convert to meters: ");
        double feetInput = Convert.ToDouble(Console.ReadLine());
        double metersFromFeet = UnitConverter.ConvertFeetToMeters(feetInput);
        Console.WriteLine($"{feetInput} feet is equal to {metersFromFeet} meters.");
    }
}