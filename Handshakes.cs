using System;

class Handshakes
{
    static void Main()
    {
        // Input for the number of students
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the formula (n * (n - 1)) / 2
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Output
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + handshakes);
    }
}
