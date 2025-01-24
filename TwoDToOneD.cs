using System;

class TwoDToOneD
{
    static void Main()
    {
        // Take user input for the number of rows and columns
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        // Define a 2D array and take user input for each element
        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element [" + i + "][" + j + "]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Define a 1D array to copy the elements of the 2D array
        int[] oneDArray = new int[rows * columns];
        int index = 0;

        // Copy elements from 2D array to 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                oneDArray[index++] = matrix[i, j];
            }
        }

        // Display the 1D array
        Console.WriteLine("1D Array:");
        foreach (int element in oneDArray)
        {
            Console.Write(element + " ");
        }
    }
}
