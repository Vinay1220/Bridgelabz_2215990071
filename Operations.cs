using System;

class Operations
{
    static void Main()
    {
        // Variables for a, b, and c
        int a, b, c;

        // Input for a, b, and c
        Console.WriteLine("Enter the value for a:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value for b:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value for c:");
        c = Convert.ToInt32(Console.ReadLine());

        // Perform the integer operations considering operator precedence
        int result1 = a + b * c;  // a + (b * c)
        int result2 = a * b + c;  // (a * b) + c
        int result3 = c + a / b;  // c + (a / b)
        int result4 = a % b + c;  // (a % b) + c

        // Output
        Console.WriteLine("a + b * c = " + result1);
        Console.WriteLine("a * b + c = " + result2);
        Console.WriteLine("c + a / b = " + result3);
        Console.WriteLine("a % b + c = " + result4);
    }
}
