using System;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10; // Remove the last digit
            count++; // Increment the count
        }
        return count; // Return the count of digits
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number); // Get the count of digits
        int[] digits = new int[count]; // Create an array to store the digits

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10; // Extract the last digit
            number /= 10; // Remove the last digit
        }

        return digits; // Return the array of digits
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true; // Non-zero digit found, it's a duck number
            }
        }
        return false; // No non-zero digit found, not a duck number
    }

    // Method to check if a number is an Armstrong number
    public static bool IsArmstrongNumber(int[] digits)
    {
        int sum = 0;
        int count = digits.Length; // Get the count of digits

        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, count); // Calculate the sum of digits raised to the power of the count
        }

        // Convert the sum back to an array of digits
        int[] sumDigits = StoreDigits(sum);

        // Compare the original digits with the sum digits
        for (int i = 0; i < count; i++)
        {
            if (digits[i] != sumDigits[i])
            {
                return false; // Not an Armstrong number
            }
        }

        return true; // Armstrong number
    }

    // Method to find the largest and second largest elements in the digits array
    public static int[] FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest; // Update the second largest
                largest = digit; // Update the largest
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit; // Update the second largest
            }
        }

        return new int[] { largest, secondLargest }; // Return the largest and second largest
    }

    // Method to find the smallest and second smallest elements in the digits array
    public static int[] FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest; // Update the second smallest
                smallest = digit; // Update the smallest
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit; // Update the second smallest
            }
        }

        return new int[] { smallest, secondSmallest }; // Return the smallest and second smallest
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Count the digits
        int count = NumberChecker.CountDigits(number);
        Console.WriteLine("Count of digits: " + count);

        // Store the digits in an array
        int[] digits = NumberChecker.StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // Check if it's a duck number
        bool isDuckNumber = NumberChecker.IsDuckNumber(digits);
        Console.WriteLine("Is duck number: " + isDuckNumber);

        // Check if it's an Armstrong number
        bool isArmstrongNumber = NumberChecker.IsArmstrongNumber(digits);
        Console.WriteLine("Is Armstrong number: " + isArmstrongNumber);

        // Find the largest and second largest digits
        int[] largestAndSecondLargest = NumberChecker.FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest and second largest digits: " + string.Join(", ", largestAndSecondLargest));

        // Find the smallest and second smallest digits
        int[] smallestAndSecondSmallest = NumberChecker.FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest and second smallest digits: " + string.Join(", ", smallestAndSecondSmallest));
    }
}