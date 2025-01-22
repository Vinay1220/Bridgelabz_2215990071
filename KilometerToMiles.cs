using System;

class KilometerToMiles
{
    static void Main()
    {
        // 1 mile = 1.6 kilometers
        double kmToMiles = 1.6; 

        // Create a Scanner-like object using Console
        Console.WriteLine("Enter the distance in kilometers:");

        // Read user input
        double km = Convert.ToDouble(Console.ReadLine());
        
        // Calculate miles
        double miles = km / kmToMiles;

        // Output the result
        Console.WriteLine("The total miles is "+miles+ " mile for the given "+km+" km.");
       
        
    }
}
