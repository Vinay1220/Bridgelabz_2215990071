using System;

class Salary
{
    static void Main()
    {
        // Input for salary and bonus
        Console.WriteLine("Enter the salary (in INR):");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the bonus (in INR):");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculate total income
        double totalIncome = salary + bonus;

        // Output
        Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+" Hence Total Income is INR "+totalIncome);
    }
}
