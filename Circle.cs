using System;

class Circle
{
    // Attribute
    public double Radius { get; set; }

    // Constructor to initialize the radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Method to calculate the area of the circle
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    // Method to calculate the circumference of the circle
    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    // Method to display the area and circumference
    public void DisplayDetails()
    {
        Console.WriteLine("Circle Details:");
        Console.WriteLine("Radius: " + Radius);
        Console.WriteLine("Area: " + CalculateArea().ToString("F2"));
        Console.WriteLine("Circumference: " + CalculateCircumference().ToString("F2"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Take input for radius from the user
        Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());

        // Create a Circle object
        Circle circle = new Circle(radius);

        // Display the area and circumference
        circle.DisplayDetails();
    }
}
