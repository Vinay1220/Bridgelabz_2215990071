using System;

class DistanceAndLine
{
    // Method to find the Euclidean distance between two points
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Calculate distance
    }

    // Method to find the equation of a line given two points
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double m; // Slope
        double b; // Y-intercept

        // Calculate the slope (m)
        if (x2 - x1 == 0) // Check for vertical line
        {
            throw new InvalidOperationException("The line is vertical; slope is undefined.");
        }
        m = (y2 - y1) / (x2 - x1);

        // Calculate the y-intercept (b)
        b = y1 - m * x1;

        return new double[] { m, b }; // Return slope and y-intercept
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input for two points
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate the Euclidean distance
        double distance = DistanceAndLine.CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance: " + distance);

        // Find the equation of the line
        try
        {
            double[] lineEquation = DistanceAndLine.FindLineEquation(x1, y1, x2, y2);
            double slope = lineEquation[0];
            double yIntercept = lineEquation[1];
            Console.WriteLine("Equation of the line: y = " + slope + " * x + " + yIntercept);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); // Handle vertical line case
        }
    }
}