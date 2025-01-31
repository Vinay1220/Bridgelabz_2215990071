using System;

class DateFormat
{
    static void Main()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Format 1: dd/MM/yyyy
        string format1 = currentDate.ToString("dd/MM/yyyy");
        Console.WriteLine("Format 1 (dd/MM/yyyy): " + format1);

        // Format 2: yyyy-MM-dd
        string format2 = currentDate.ToString("yyyy-MM-dd");
        Console.WriteLine("Format 2 (yyyy-MM-dd): " + format2);

        // Format 3: EEE, MMM dd, yyyy (day abbreviation, month abbreviation, day, year)
        string format3 = currentDate.ToString("ddd, MMM dd, yyyy");
        Console.WriteLine("Format 3 (EEE, MMM dd, yyyy): " + format3);
    }
}
