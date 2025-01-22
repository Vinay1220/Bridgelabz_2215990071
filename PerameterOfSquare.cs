using System;

class PerimeterOfSquare
{
    static void Main()
    {
        // Variable for perimeter
        double perimeter;

        // Input for perimeter
        Console.WriteLine("Enter the perimeter of the square:");
        perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side of the square
        double side = perimeter / 4;

        // Output the result
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
