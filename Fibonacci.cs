using System;

class Fibonacci
{
    // Function to generate and print the Fibonacci sequence
    static void GenerateFibonacci(int terms)
    {
        if (terms <= 0)
        {
            Console.WriteLine("The number of terms must be greater than 0.");
            return;
        }

        int first = 0, second = 1;

        Console.WriteLine("Fibonacci Sequence:");
        
        for (int i = 1; i <= terms; i++)
        {
            Console.Write(first + " "); // Print the current term
            int next = first + second; // Calculate the next term
            first = second;            // Shift first to second
            second = next;             // Shift second to next
        }

        Console.WriteLine(); 
    }

    static void Main(string[] args)
    {
       
        Console.WriteLine("Enter the number of terms for the Fibonacci sequence:");
        int terms = int.Parse(Console.ReadLine());

        // Call the GenerateFibonacci function
        GenerateFibonacci(terms);
    }
}
