using System;

class HarshadNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number, sum = 0;

        while (number != 0)
        {
            sum += number % 10;  // Add last digit to sum
            number /= 10;        // Remove last digit
        }

        if (originalNumber % sum == 0)
        {
            Console.WriteLine(originalNumber + " is a Harshad number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not a Harshad number.");
        }
    }
}
