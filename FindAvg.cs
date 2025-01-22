using System;

class AverageMark
{
    static void Main(string[] args)
    {
        // Sam's marks in each subject
        int mathsMark = 94;
        int physicsMark = 95;
        int chemistryMark = 96;

        // Total marks for each subject
        int totalMarks = 100;

        // Calculate the average percentage
        double averageMark = (mathsMark + physicsMark + chemistryMark) / 3.0;

        // Output the result
        Console.WriteLine("Sam’s average mark in PCM is " + averageMark);
    }
}