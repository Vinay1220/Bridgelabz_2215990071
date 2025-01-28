using System;

class SpringSeason
{
    static void Main()
    {
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);

        // Output
        if (isSpring) Console.WriteLine("It's a Spring Season.");
        else Console.WriteLine("Not a Spring Season.");
    }

    static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20) || (month == 6 && day <= 20) || (month > 3 && month < 6))
        {
            return true;
        }
        return false;
    }
}
