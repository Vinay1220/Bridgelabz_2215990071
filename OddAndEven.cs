using System;

class OddAndEven
{
    static void Main()
    {
        // Get the limit number from the user
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Not a natural number.");
            return;
        }

        // Arrays to store odd and even numbers
        int[] odds = new int[number / 2 + 1];
        int[] evens = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        // Loop to categorize numbers into odd and even
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                evens[evenIndex++] = i;
            else
                odds[oddIndex++] = i;
        }

        
        // Step 4: Display the results
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers[..oddIndex]));
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers[..evenIndex]));
    }
}
