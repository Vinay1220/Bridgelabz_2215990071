using System;

class AgeOfStudents
{
    static void Main()
    {
		// Define an array to store the ages of 10 students
        int[] ages = new int[10];

		// Loop to take input for each student's age
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
        }
	
		 // Loop through the array and check voting eligibility
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
                Console.WriteLine("Invalid age: " + ages[i]);
            else if (ages[i] >= 18)
                Console.WriteLine("The student with the age " + ages[i] + " can vote.");
            else
                Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
        }
    }
}
