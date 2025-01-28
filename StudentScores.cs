using System;

class StudentScores
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Generate random scores for students
        int[,] scores = GenerateRandomScores(numStudents);
        
        // Calculate total, average, and percentage for each student
        double[,] results = CalculateResults(scores);
        
        // Display the scorecard
        DisplayScorecard(scores, results);
    }

    // Method to generate random scores for Physics, Chemistry, and Math
    static int[,] GenerateRandomScores(int numStudents)
    {
        Random rand = new Random();
        int[,] scores = new int[numStudents, 3];

        for (int i = 0; i < numStudents; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                scores[i, j] = rand.Next(40, 101); // Random scores between 40 and 100
            }
        }
        return scores;
    }

    // Method to calculate total, average, and percentage for each student
    static double[,] CalculateResults(int[,] scores)
    {
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 3];

        for (int i = 0; i < numStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2]; // Sum of PCM scores
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100; // Assuming max score per subject is 100

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    // Method to display the scorecard in tabular format
    static void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.Write((i + 1) + "\t"); // Student index
            for (int j = 0; j < 3; j++)
            {
                Console.Write(scores[i, j] + "\t"); // Subject scores
            }
            for (int j = 0; j < 3; j++)
            {
                Console.Write(results[i, j] + "\t"); // Total, Average, Percentage
            }
            Console.WriteLine();
        }
    }
}