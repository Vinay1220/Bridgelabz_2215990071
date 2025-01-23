using System;

class Marks
{
    static void Main()
    {
        Console.WriteLine("Enter marks for Physics:");
        double physics = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Chemistry:");
        double chemistry = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Maths:");
        double maths = double.Parse(Console.ReadLine());

        double total = physics + chemistry + maths;
        double percentage = total / 3;

        Console.WriteLine("Average Marks: " + percentage);

        if (percentage >= 90)
        {
            Console.WriteLine("Grade: A (Excellent)");
        }
        else if (percentage >= 75)
        {
            Console.WriteLine("Grade: B (Good)");
        }
        else if (percentage >= 50)
        {
            Console.WriteLine("Grade: C (Average)");
        }
        else
        {
            Console.WriteLine("Grade: F (Fail)");
        }
    }
}
