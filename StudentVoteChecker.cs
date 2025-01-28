using System;

public class StudentVoteChecker
{
    // Method to check if a student can vote based on age
    public bool CanStudentVote(int age)
    {
        // Validate the age
        if (age < 0)
        {
            return false; // Cannot vote if age is negative
        }

        // Check if age is 18 or above
        return age >= 18;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of StudentVoteChecker
        StudentVoteChecker voteChecker = new StudentVoteChecker();

        // Define an array to hold the ages of 10 students
        int[] studentAges = new int[10];

        // Loop to take user input for each student's age
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                studentAges[i] = age; // Store the age in the array

                // Check if the student can vote and display the result
                if (voteChecker.CanStudentVote(age))
                {
                    Console.WriteLine($"Student {i + 1} can vote.");
                }
                else
                {
                    Console.WriteLine($"Student {i + 1} cannot vote.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                i--; // Decrement i to repeat the input for the same student
            }
        }
    }
}