using System;

class DoubleOp
{
    static void Main()
    {
        // Variables for a, b, and c as double data type
        double a, b, c;

        // Input for a, b, and c
        Console.WriteLine("Enter the value for a:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value for b:");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value for c:");
        c = Convert.ToDouble(Console.ReadLine());

        // Perform the double operations considering operator precedence
        double result1 = a + b * c;  // a + (b * c)
        double result2 = a * b + c;  // (a * b) + c
        double result3 = c + a / b;  // c + (a / b)
        double result4 = a % b + c;  // (a % b) + c

        // Output
        Console.WriteLine("The results of Double Operations are:");
        Console.WriteLine("a + b * c = "+result1);
        Console.WriteLine("a * b + c = "+result2);
        Console.WriteLine("c + a / b = "+result3);
    }
}
