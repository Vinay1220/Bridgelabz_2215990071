using System;

class GCDLCMCalculator
{
    // Function to calculate the GCD using the Euclidean algorithm
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate the LCM using the formula: LCM(a, b) = |a * b| / GCD(a, b)
    static int CalculateLCM(int a, int b)
    {
        return Math.Abs(a * b) / CalculateGCD(a, b);
    }

    // Function to take input from the user
    static void GetInput(out int a, out int b)
    {
        Console.WriteLine("Enter the first number:");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        b = int.Parse(Console.ReadLine());
    }

    // Function to display the results
    static void DisplayResults(int a, int b, int gcd, int lcm)
    {
        Console.WriteLine("The GCD of " + a + " and " + b + " is: " + gcd);
        Console.WriteLine("The LCM of " + a + " and " + b + " is: " + lcm);
    }

    static void Main(string[] args)
    {
        // Get input from the user
        int num1, num2;
        GetInput(out num1, out num2);

        // Calculate GCD and LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2);

        // Display the results
        DisplayResults(num1, num2, gcd, lcm);
    }
}
