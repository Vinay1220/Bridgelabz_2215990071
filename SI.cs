using System;

class SI
{
    static void Main()
    {
        // Variables for principal, rate, and time
        double principal, rate, time, simpleInterest;

        // Input for principal, rate, and time
        Console.WriteLine("Enter the principal amount:");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the rate of interest:");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time period (in years):");
        time = Convert.ToDouble(Console.ReadLine());

        // Calculate simple interest
        simpleInterest = (principal * rate * time) / 100;

        // Output the result
        Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+", and Time "+time);
    }
}
