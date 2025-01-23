using System;

class DayOfWeek
{
    static void Main()
    {
        Console.WriteLine("Enter month (1-12):");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter day:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter year:");
        int y = int.Parse(Console.ReadLine());

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        Console.WriteLine("The day of the week is: " + d0);
        // 0 = Sunday, 1 = Monday, ..., 6 = Saturday
    }
}
