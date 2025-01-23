using System;

class Bonus
{
    static void Main()
    {
        Console.WriteLine("Enter your salary:");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter years of service:");
        int years = int.Parse(Console.ReadLine());

        if (years > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine("Bonus: " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus.");
        }
    }
}
