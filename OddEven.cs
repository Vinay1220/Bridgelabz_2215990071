using System;

class OddEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i + " is " + (i % 2 == 0 ? "Even" : "Odd"));
        }
    }
}
