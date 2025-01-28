using System;

class Handshakes2
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int handshakes = (n * (n - 1)) / 2;

        // Output
        Console.WriteLine("Maximum number of handshakes among " + n + " students is " + handshakes + ".");
    }

   
}
