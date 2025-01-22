using System;

class CmToFeet
{
    static void Main()
    {
        // Constants for conversion
        const double cmToInches = 2.54; // 1 inch = 2.54 cm
        const int inchesInFoot = 12; // 1 foot = 12 inches

        // Input for height in centimeters
        Console.WriteLine("Enter your height in centimeters:");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Convert height to inches
        double heightInches = heightCm / cmToInches;

        // Calculate feet and remaining inches
        int feet = (int)(heightInches / inchesInFoot);
        int inches = (int)(heightInches % inchesInFoot);

        // Output
        Console.WriteLine("Your Height in cm is " + heightCm + " while in feet is " + feet + " and inches is " + inches);
    }
}
