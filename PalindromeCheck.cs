using System;

class PalindromeCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it is a palindrome:");
        string str = Console.ReadLine();

        // Convert the string to lowercase and remove spaces for a proper comparison
        string processedString = str.Replace(" ", "").ToLower();

        // Convert the string to a character array
        char[] charArray = processedString.ToCharArray();

        // Check if the string is a palindrome
        bool isPalindrome = true;
        for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
        {
            if (charArray[i] != charArray[j])
            {
                isPalindrome = false;
                break;
            }
        }

        // Display the result
        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}
