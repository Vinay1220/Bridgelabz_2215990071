using System;

class UnitConverter
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9; // Conversion formula
        return fahrenheit2celsius;
    }

    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9 / 5) + 32; // Conversion formula
        return celsius2fahrenheit;
    }

    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592; // Conversion factor
        return pounds * pounds2kilograms;
    }

    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462; // Conversion factor
        return kilograms * kilograms2pounds;
    }

    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541; // Conversion factor
        return gallons * gallons2liters;
    }

    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172; // Conversion factor
        return liters * liters2gallons;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the UnitConverter class
        Console.WriteLine("Unit Converter");

        // Convert Fahrenheit to Celsius
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsiusFromFahrenheit = UnitConverter.ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} °F is equal to {celsiusFromFahrenheit} °C.");

        // Convert Celsius to Fahrenheit
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheitFromCelsius = UnitConverter.ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius} °C is equal to {fahrenheitFromCelsius} °F.");

        // Convert pounds to kilograms
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilogramsFromPounds = UnitConverter.ConvertPoundsToKilograms(pounds);
        Console.WriteLine($"{pounds} lbs is equal to {kilogramsFromPounds} kg.");

        // Convert kilograms to pounds
        Console.Write("Enter weight in kilograms: ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        double poundsFromKilograms = UnitConverter.ConvertKilogramsToPounds(kilograms);
        Console.WriteLine($"{kilograms} kg is equal to {poundsFromKilograms} lbs.");

        // Convert gallons to liters
        Console.Write("Enter volume in gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        double litersFromGallons = UnitConverter.ConvertGallonsToLiters(gallons);
        Console.WriteLine($"{gallons} gallons is equal to {litersFromGallons} liters.");

        // Convert liters to gallons
        Console.Write("Enter volume in liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        double gallonsFromLiters = UnitConverter.ConvertLitersToGallons(liters);
        Console.WriteLine($"{liters} liters is equal to {gallonsFromLiters} gallons.");
    }
}