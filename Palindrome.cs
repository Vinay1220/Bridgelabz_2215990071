using System;

class Palindrome
{
    // Function to take input from the user
    static string GetInput()
    {
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        return Console.ReadLine().Trim();
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string input)
    {
        int start = 0;
        int end = input.Length - 1;

        while (start < end)
        {
            if (char.ToLower(input[start]) != char.ToLower(input[end])) // Case insensitive comparison
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    // Function to display the result
    static void DisplayResult(string input, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine("The string \"" + input + "\" is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string \"" + input + "\" is not a palindrome.");
        }
    }

    static void Main(string[] args)
    {
        // Get input from the user
        string input = GetInput();

        // Check if the input is a palindrome
        bool result = IsPalindrome(input);

        // Result
        DisplayResult(input, result);
    }
}
