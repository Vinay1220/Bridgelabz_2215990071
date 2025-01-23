using System;

class PrimeNum
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(number + " is a Prime Number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Prime Number.");
        }
    }
}
