using System;

class Athlete
{
    static void Main()
    {
        // Variables for the sides of the triangle
        double side1, side2, side3;

        // Input for the sides
        Console.WriteLine("Enter the length of side 1 (in meters):");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2 (in meters):");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3 (in meters):");
        side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds required to complete 5 km
        double totalRounds = 5000 / perimeter;  // 5000 meters = 5 km

        // Output the result
        Console.WriteLine("The total number of rounds the athlete will run is "+totalRounds+" to complete 5 km");
    }
}
