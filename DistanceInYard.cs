using System;

class DistanceInYard
{
    static void Main()
    {
        // Constants for conversion
        const int feetInYard = 3; // 1 yard = 3 feet
        const int yardsInMile = 1760; // 1 mile = 1760 yards

        // Input for distance in feet
        Console.WriteLine("Enter the distance in feet:");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Convert feet to yards
        double distanceInYards = distanceInFeet / feetInYard;

        // Convert feet to miles
        double distanceInMiles = distanceInYards / yardsInMile;

        // Output
        Console.WriteLine("Your distance in feet is " + distanceInFeet + " while in yards is " + distanceInYards + " and miles is " + distanceInMiles);
    }
}
