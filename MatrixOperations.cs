using System;

class MatrixOperations
{
    static void Main()
    {
        // Generate two random 3x3 matrices
        int[,] matrix1 = GenerateRandomMatrix(3, 3);
        int[,] matrix2 = GenerateRandomMatrix(3, 3);

        // Display the generated matrices
        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);
        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);

        // Perform and display matrix addition
        Console.WriteLine("Addition of Matrices:");
        DisplayMatrix(AddMatrices(matrix1, matrix2));

        // Perform and display matrix subtraction
        Console.WriteLine("Subtraction of Matrices:");
        DisplayMatrix(SubtractMatrices(matrix1, matrix2));

        // Perform and display matrix multiplication
        Console.WriteLine("Multiplication of Matrices:");
        DisplayMatrix(MultiplyMatrices(matrix1, matrix2));

        // Perform and display matrix transpose
        Console.WriteLine("Transpose of Matrix 1:");
        DisplayMatrix(TransposeMatrix(matrix1));
    }

    // Method to generate a random matrix with given rows and columns
    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        Random rand = new Random();
        int[,] matrix = new int[rows, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(1, 10); // Random values between 1 and 9
            }
        }
        return matrix;
    }

    // Method to add two matrices
    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j]; // Element-wise addition
            }
        }
        return result;
    }

    // Method to subtract two matrices
    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j]; // Element-wise subtraction
            }
        }
        return result;
    }

    // Method to multiply two matrices
    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix2.GetLength(1);
        int common = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < common; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j]; // Dot product
                }
            }
        }
        return result;
    }

    // Method to compute the transpose of a matrix
    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transpose = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j]; // Swapping rows and columns
            }
        }
        return transpose;
    }

    // Method to display a matrix in a tabular format
    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t"); // Tab-separated values
            }
            Console.WriteLine();
        }
    }
}
