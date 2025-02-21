using System;
using System.IO;

class Program
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Amount and rate must be positive");
        }
        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter the principal amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            int years = int.Parse(Console.ReadLine());

            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("Calculated Interest: " + interest);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid input: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
    }
}
