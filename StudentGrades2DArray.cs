using System;

class StudentGrades2DArray
{
    static void Main()
    {
        //user to input the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Create a 2D array to store marks for Physics, Chemistry, and Maths
        int[,] marks = new int[numberOfStudents, 3]; // [Student][0=Physics, 1=Chemistry, 2=Maths]
        double[] percentages = new double[numberOfStudents]; // Array to store percentages
        string[] grades = new string[numberOfStudents]; // Array to store grades

        // Input marks for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1) + ":");

            // Input marks for Physics
            Console.Write("Enter marks for Physics: ");
            marks[i, 0] = GetValidMarks();

            // Input marks for Chemistry
            Console.Write("Enter marks for Chemistry: ");
            marks[i, 1] = GetValidMarks();

            // Input marks for Maths
            Console.Write("Enter marks for Maths: ");
            marks[i, 2] = GetValidMarks();

            // Calculate percentage
            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            // Determine grade based on percentage
            grades[i] = GetGrade(percentages[i]);
        }

        // Display the marks, percentage, and grade for each student
        Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                marks[i, 0] + "\t" +
                marks[i, 1] + "\t\t" +
                marks[i, 2] + "\t" +
                percentages[i].ToString("0.00") + "\t\t" +
                grades[i]);
        }
    }

    // Method to ensure valid (non-negative) marks
    static int GetValidMarks()
    {
        int value;
        while (true)
        {
            value = int.Parse(Console.ReadLine());
            if (value >= 0) return value; // Valid value
            Console.Write("Invalid input. Please enter non-negative marks: ");
        }
    }

    // Method to determine grade based on percentage
    static string GetGrade(double percentage)
    {
        if (percentage >= 90) return "A+";
        if (percentage >= 80) return "A";
        if (percentage >= 70) return "B+";
        if (percentage >= 60) return "B";
        if (percentage >= 50) return "C";
        if (percentage >= 40) return "D";
        return "F";
    }
}
