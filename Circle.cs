using System;

class Circle
{
    private double radius;

    // Default constructor
    public Circle() : this(1.0) // Calls parameterized constructor
    {
    }

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public void Display()
    {
        Console.WriteLine("Radius: " + radius + ", Area: " + GetArea());
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Circle defaultCircle = new Circle();
        defaultCircle.Display();

        Circle customCircle = new Circle(5.0);
        customCircle.Display();
    }
}
