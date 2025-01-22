using System;

class PenDistribution
{
    static void Main(string[] args)
    {
        // Total pens and number of students
        int totalPens = 14;
        int numberOfStudents = 3;

        // Calculate pens per student and remaining pens
        int pensPerStudent = totalPens / numberOfStudents;
        int remainingPens = totalPens % numberOfStudents;

        // Output the result
        Console.WriteLine("The Pen Per Student is "+pensPerStudent+" and the remaining pen not distributed is "+remainingPens);
    }
}
