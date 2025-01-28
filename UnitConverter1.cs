using System;

class UnitConverter
{
    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3; // 1 yard = 3 feet
        return yards * yards2feet;
    }

    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333; // 1 foot = 1/3 yard
        return feet * feet2yards;
    }

    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701; // 1 meter = 39.3701 inches
        return meters * meters2inches;
    }

    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254; // 1 inch = 0.0254 meters
        return inches * inches2meters;
    }

    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54; // 1 inch = 2.54 centimeters
        return inches * inches2cm;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the UnitConverter class
        Console.WriteLine("Unit Converter");

        // Convert yards to feet
        Console.Write("Enter yards to convert to feet: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        double feetFromYards = UnitConverter.ConvertYardsToFeet(yards);
        Console.WriteLine($"{yards} yards is equal to {feetFromYards} feet.");

        // Convert feet to yards
        Console.Write("Enter feet to convert to yards: ");
        double feetInput = Convert.ToDouble(Console.ReadLine());
        double yardsFromFeet = UnitConverter.ConvertFeetToYards(feetInput);
        Console.WriteLine($"{feetInput} feet is equal to {yardsFromFeet} yards.");

        // Convert meters to inches
        Console.Write("Enter meters to convert to inches: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        double inchesFromMeters = UnitConverter.ConvertMetersToInches(meters);
        Console.WriteLine($"{meters} meters is equal to {inchesFromMeters} inches.");

        // Convert inches to meters
        Console.Write("Enter inches to convert to meters: ");
        double inchesInput = Convert.ToDouble(Console.ReadLine());
        double metersFromInches = UnitConverter.ConvertInchesToMeters(inchesInput);
        Console.WriteLine($"{inchesInput} inches is equal to {metersFromInches} meters.");

        // Convert inches to centimeters
        Console.Write("Enter inches to convert to centimeters: ");
        double inchesForCm = Convert.ToDouble(Console.ReadLine());
        double centimetersFromInches = UnitConverter.ConvertInchesToCentimeters(inchesForCm);
        Console.WriteLine($"{inchesForCm} inches is equal to {centimetersFromInches} centimeters.");
    }
}