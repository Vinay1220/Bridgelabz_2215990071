using System;

class TimeZone
{
    static void Main()
    {
        // Current time as UTC
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        // Display time in GMT (UTC)
        Console.WriteLine("GMT (Greenwich Mean Time): " + utcTime.ToString("yyyy-MM-dd HH:mm:ss"));

        // Display time in IST (Indian Standard Time, UTC +5:30)
        TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istTimeZone);
        Console.WriteLine("IST (Indian Standard Time): " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));

        // Display time in PST (Pacific Standard Time, UTC -8:00)
        TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstTimeZone);
        Console.WriteLine("PST (Pacific Standard Time): " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}
