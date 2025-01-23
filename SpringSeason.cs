using System;

class SpringSeason
{
    static void Main()
    {
        Console.WriteLine("Enter month:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter day:");
        int day = int.Parse(Console.ReadLine());

        if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
