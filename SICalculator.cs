using System;

class SICalculator
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = double.Parse(Console.ReadLine());

        double interest = CalculateSimpleInterest(principal, rate, time);

 Console.WriteLine("The Simple Interest is " + interest + " for Principal " + principal + ", Rate of Interest " + rate + ", and Time " + time + ".");    }

    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}
