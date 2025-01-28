using System;

class TriangularParkRounds
{
    static void Main()
    {
        Console.Write("Enter the first side of the triangle (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second side of the triangle (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the third side of the triangle (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        double rounds = CalculateRounds(side1, side2, side3);

        // Output
        Console.WriteLine("The athlete needs to complete " + Math.Ceiling(rounds) + " rounds to cover 5 km.");
    }

    static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        return 5000 / perimeter; // 5 km = 5000 meters
    }
}
