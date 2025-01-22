using System;

class PoundToKm
{
    static void Main()
    {
        // Variable for weight in pounds
        double weightInPounds, weightInKg;

        // Input for weight in pounds
        Console.WriteLine("Enter the weight in pounds:");
        weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms (1 pound = 2.2 kg)
        weightInKg = weightInPounds * 2.2;

        // Output the result
        Console.WriteLine("The weight of the person in pounds is "+weightInPounds+" and in kg is "+weightInKg);
    }
}
