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

            Console.WriteLine("Value at index: " +numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
    }
}
