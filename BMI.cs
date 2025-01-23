using System;

class BMI
{
    static void Main()
    {
        Console.WriteLine("Enter weight (in kg):");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height (in cm):");
        double height = double.Parse(Console.ReadLine());
        height /= 100; // Convert cm to meters

        double bmi = weight / (height * height);

        Console.WriteLine("Your BMI is: " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi < 24.9)
        {
            Console.WriteLine("Normal weight");
        }
        else if (bmi < 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obesity");
        }
    }
}
