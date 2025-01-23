using System;

class LeapYearUsingIfElse
{
    static void Main()
    {
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());

        if (year >= 1582)
        {
            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine(year + " is a Leap Year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Year must be greater than or equal to 1582.");
        }
    }
}
