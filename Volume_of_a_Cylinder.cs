using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter the radius of the cylinder: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the cylinder: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(radius, 2) * height;

        Console.WriteLine(volume);
    }
}
