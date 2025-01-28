using System;

class TrigonometricCalculator
{
    static void Main()
    {
        // Get angle input
        Console.Write("Enter the angle (in degrees): ");
        double angle = double.Parse(Console.ReadLine());

        // Calculate trigonometric values
        double[] trigValues = CalculateTrigonometricFunctions(angle);

        // Output
        Console.WriteLine("For an angle of " + angle + " degrees:");
        Console.WriteLine("Sine: " + trigValues[0]);
        Console.WriteLine("Cosine: " + trigValues[1]);
        Console.WriteLine("Tangent: " + trigValues[2]);
    }

    // Method to calculate sine, cosine, and tangent of an angle
    static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle to radians
        double radians = Math.PI * angle / 180;

        // Calculate trigonometric functions
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }
}
