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

    // Method to reverse the digits array
    public static int[] ReverseDigits(int[] digits)
    {
        int[] reversed = new int[digits.Length]; // Create an array for reversed digits
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i]; // Reverse the order
        }
        return reversed; // Return the reversed array
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length) // Check if lengths are different
        {
            return false; // Arrays are not equal
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i]) // Check for element-wise equality
            {
                return false; // Arrays are not equal
            }
        }

        return true; // Arrays are equal
    }

    // Method to check if a number is a palindrome
    public static bool IsPalindrome(int number)
    {
        int[] digits = StoreDigits(number); // Store the digits
        int[] reversedDigits = ReverseDigits(digits); // Reverse the digits
        return AreArraysEqual(digits, reversedDigits); // Check if original and reversed are equal
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        int[] digits = StoreDigits(number); // Store the digits
        foreach (int digit in digits)
        {
            if (digit != 0) // Check for non-zero digit
            {
                return true; // Found a non-zero digit, it's a duck number
            }
        }
        return false; // No non-zero digit found, not a duck number
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

        // Reverse the digits array
        int[] reversedDigits = NumberChecker.ReverseDigits(digits);
        Console.WriteLine("Reversed Digits: " + string.Join(", ", reversedDigits));

        // Check if the number is a palindrome
        bool isPalindrome = NumberChecker.IsPalindrome(number);
        Console.WriteLine("Is Palindrome: " + isPalindrome);

        // Check if the number is a duck number
        bool isDuckNumber = NumberChecker.IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuckNumber);
    }
}