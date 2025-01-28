using System;

class ZaraBonusCalculator
{
    // Method to determine the salary and years of service
    public static double[,] DetermineSalaryAndYears(int numberOfEmployees)
    {
        Random random = new Random();
        double[,] employeeData = new double[numberOfEmployees, 2]; // 2D array to store salary and years of service

        for (int i = 0; i < numberOfEmployees; i++)
        {
            // Generate a random 5-digit salary and years of service (0 to 20 years)
            employeeData[i, 0] = random.Next(10000, 100000); // Salary
            employeeData[i, 1] = random.Next(0, 21); // Years of service
        }

        return employeeData; // Return the 2D array
    }

    // Method to calculate the new salary and bonus
    public static double[,] CalculateNewSalaryAndBonus(double[,] employeeData)
    {
        int numberOfEmployees = employeeData.GetLength(0);
        double[,] newSalaryAndBonus = new double[numberOfEmployees, 2]; // 2D array to store new salary and bonus

        for (int i = 0; i < numberOfEmployees; i++)
        {
            double oldSalary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02; // Determine bonus percentage
            double bonus = oldSalary * bonusPercentage; // Calculate bonus
            double newSalary = oldSalary + bonus; // Calculate new salary

            newSalaryAndBonus[i, 0] = newSalary; // Store new salary
            newSalaryAndBonus[i, 1] = bonus; // Store bonus
        }

        return newSalaryAndBonus; // Return the new salary and bonus array
    }

    // Method to calculate the sums and display results
    public static void CalculateAndDisplaySums(double[,] employeeData, double[,] newSalaryAndBonus)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Employee\tOld Salary\tNew Salary\tBonus");
        Console.WriteLine("------------------------------------------------");

        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            double oldSalary = employeeData[i, 0];
            double newSalary = newSalaryAndBonus[i, 0];
            double bonus = newSalaryAndBonus[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine((i + 1) + "\t\t" + oldSalary.ToString("C") + "\t" + newSalary.ToString("C") + "\t" + bonus.ToString("C"));
        }

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Total\t\t" + totalOldSalary.ToString("C") + "\t" + totalNewSalary.ToString("C") + "\t" + totalBonus.ToString("C"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numberOfEmployees = 10;

        // Determine salary and years of service
        double[,] employeeData = ZaraBonusCalculator.DetermineSalaryAndYears(numberOfEmployees);

        // Calculate new salary and bonus
        double[,] newSalaryAndBonus = ZaraBonusCalculator.CalculateNewSalaryAndBonus(employeeData);

        // Calculate sums and display results
        ZaraBonusCalculator.CalculateAndDisplaySums(employeeData, newSalaryAndBonus);
    }
}