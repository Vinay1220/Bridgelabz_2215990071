using System;

class LargestSecondLargestDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Create an array to store digits
        int[] digits = new int[10];
        int index = 0;

        // Extract digits and store them in the array
        while (number > 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        // Find largest and second largest digits
        int largest = int.MinValue, secondLargest = int.MinValue;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display the largest and second largest digit
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}
