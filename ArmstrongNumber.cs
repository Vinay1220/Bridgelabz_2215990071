using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number, sum = 0;

        while (originalNumber != 0)
        {
            int digit = originalNumber % 10; // Get last digit
            sum += digit * digit * digit;    // Add cube of digit to sum
            originalNumber /= 10;           // Remove last digit
        }

        if (sum == number)
        {
            Console.WriteLine(number + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(number + " is not an Armstrong number.");
        }
    }
}
