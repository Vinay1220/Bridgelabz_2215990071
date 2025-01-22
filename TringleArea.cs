using System;

class TringleArea
{
    static void Main()
    {
        // Variables for base and height
        double baseLength, height;

        // Input for base and height
        Console.WriteLine("Enter the base of the triangle (in inches):");
        baseLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle (in inches):");
        height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle in square inches
        double areaInches = 0.5 * baseLength * height;

        // Convert area to square centimeters (1 inch = 2.54 cm, so 1 inch² = 2.54² cm²)
        double areaCm = areaInches * 2.54 * 2.54;

        // Output 
        Console.WriteLine("Your area in square inches is " + areaInches + " and in square centimeters is " + areaCm);
    }
}
