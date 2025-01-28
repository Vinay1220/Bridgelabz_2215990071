using System;

class Quadratic
{
    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c; // Calculate the discriminant

        if (delta > 0)
        {
            // Two distinct roots
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 }; // Return the roots
        }
        else if (delta == 0)
        {
            // One double root
            double root = -b / (2 * a);
            return new double[] { root }; // Return the single root
        }
        else
        {
            // No real roots
            return new double[0]; // Return an empty array
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input coefficients a, b, and c
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Find the roots of the quadratic equation
        double[] roots = Quadratic.FindRoots(a, b, c);

        // Display the results
        if (roots.Length == 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("The equation has one root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("The equation has two roots: " + roots[0] + " and " + roots[1]);
        }
    }
}