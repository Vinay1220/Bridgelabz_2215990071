using System;

class LargestSecondLargestDigit2
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Initial size for the digits array
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Extract digits and store them in the array
        while (number > 0)
        {
            // If the array is full, increase its size by 10
            if (index == maxDigit)
            {
                maxDigit += 10; // Increase the size of the array
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length); // Copy old digits to the new array
                digits = temp; // Reassign the digits array to the new larger array
            }

            digits[index++] = number % 10; // Extract last digit and store it in the array
            number /= 10; // Remove the last digit from the number
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
