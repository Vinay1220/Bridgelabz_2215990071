using System;

class MarksAndGrades
{
    static void Main()
    {
        // user to enter the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Arrays to store marks, percentages, and grades
        double[] physics = new double[numStudents];
        double[] chemistry = new double[numStudents];
        double[] maths = new double[numStudents];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Input marks for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.Write("Enter Physics marks for student " + (i + 1) + ": ");
            physics[i] = GetValidMarks();

            Console.Write("Enter Chemistry marks for student " + (i + 1) + ": ");
            chemistry[i] = GetValidMarks();

            Console.Write("Enter Maths marks for student " + (i + 1) + ": ");
            maths[i] = GetValidMarks();

            // Calculate percentage
            percentages[i] = (physics[i] + chemistry[i] + maths[i]) / 3.0;

            // Determine grade
            grades[i] = GetGrade(percentages[i]);
        }

        // Display the results
        Console.WriteLine("\nPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine(physics[i].ToString("0.00") + "\t" + chemistry[i].ToString("0.00") + "\t" + maths[i].ToString("0.00") + "\t" + percentages[i].ToString("0.00") + "\t" + grades[i]);
        }
    }

    // Method to ensure valid marks
    static double GetValidMarks()
    {
        double marks;
        while (true)
        {
            marks = double.Parse(Console.ReadLine());
            if (marks >= 0) return marks;
            Console.Write("Invalid marks. Please enter a positive value: ");
        }
    }

    // Method to determine grade based on percentage
    static string GetGrade(double percentage)
    {
        if (percentage >= 90) return "A";
        if (percentage >= 80) return "B";
        if (percentage >= 70) return "C";
        if (percentage >= 60) return "D";
        return "F";
    }
}
