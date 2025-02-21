using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the index to retrieve value: ");
            int index = int.Parse(Console.ReadLine());

            try
            {
                int value = numbers[index];
                Console.Write("Enter the divisor: ");
                int divisor = int.Parse(Console.ReadLine());
                
                try
                {
                    int result = value / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
    }
}
