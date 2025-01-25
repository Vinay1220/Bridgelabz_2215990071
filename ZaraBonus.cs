using System;

class ZaraBonus
{
    static void Main()
    {
        // Define arrays to store salary, years of service, bonus, and new salary
        double[] salary = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];
        
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        // Loop to input salary and years of service for each employee
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter details for employee " + (i + 1) + ":");
            
            // Input and validate salary
            Console.Write("Enter salary: ");
            salary[i] = double.Parse(Console.ReadLine());
            if (salary[i] <= 0)
            {
                Console.WriteLine("Invalid salary, please enter again.");
                i--;
                continue;
            }

            // Input and validate years of service
            Console.Write("Enter years of service: ");
            yearsOfService[i] = double.Parse(Console.ReadLine());
            if (yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid years of service, please enter again.");
                i--;
                continue;
            }
        }

        // Loop to calculate bonus and new salary, and calculate total values
        for (int i = 0; i < 10; i++)
        {
            if (yearsOfService[i] >= 5)
                bonus[i] = salary[i] * 0.05; // 5% bonus for more than 5 years of service
            else
                bonus[i] = salary[i] * 0.02; // 2% bonus for less than 5 years of service
            
            newSalary[i] = salary[i] + bonus[i]; // New salary after adding bonus

            totalBonus += bonus[i]; // Accumulate total bonus
            totalOldSalary += salary[i]; // Accumulate total old salary
            totalNewSalary += newSalary[i]; // Accumulate total new salary
        }

        // Display total bonus and salary
        Console.WriteLine("Total bonus payout: " + totalBonus);
        Console.WriteLine("Total old salary: " + totalOldSalary);
        Console.WriteLine("Total new salary: " + totalNewSalary);
    }
}
