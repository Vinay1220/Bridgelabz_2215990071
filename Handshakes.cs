using System;

class Handshakes
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int handshakes = CalculateHandshakes(n);

        // Output
        Console.WriteLine("Maximum number of handshakes among " + n + " students is " + handshakes + ".");
    }

    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}
