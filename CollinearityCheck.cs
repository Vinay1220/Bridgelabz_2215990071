using System;

class CollinearityCheck
{
    // Method to check collinearity using the slope formula
    static bool ArePointsCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate slopes
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);

        // Compare slopes
        return slopeAB == slopeBC;
    }

    // Method to check collinearity using the area of the triangle formula
    static bool ArePointsCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate the area of the triangle
        double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // Points are collinear if the area is zero
        return area == 0;
    }

    static void Main(string[] args)
    {
        // Input points
        Console.WriteLine("Enter coordinates of point A (x1, y1): ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinates of point B (x2, y2): ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinates of point C (x3, y3): ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        double y3 = Convert.ToDouble(Console.ReadLine());

        // Check collinearity using both methods
        bool collinearUsingSlope = ArePointsCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        bool collinearUsingArea = ArePointsCollinearUsingArea(x1, y1, x2, y2, x3, y3);

        // Output results
        Console.WriteLine("Are the points collinear (using slope)? " + (collinearUsingSlope ? "Yes" : "No"));
        Console.WriteLine("Are the points collinear (using area)? " + (collinearUsingArea ? "Yes" : "No"));
    }
}
