using System;

class BMIProgram
{
    static void Main(string[] args)
    {
        const int teamSize = 10;
        double[,] personData = new double[teamSize, 3]; // 2D array to store weight, height, and BMI
        string[] bmiStatuses = new string[teamSize]; // Array to store BMI statuses

        // Input weight and height for each person
        for (int i = 0; i < teamSize; i++)
        {
            Console.WriteLine($"Enter weight (in kg) for person {i + 1}:");
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter height (in cm) for person {i + 1}:");
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate BMI and determine statuses
        for (int i = 0; i < teamSize; i++)
        {
            personData[i, 2] = CalculateBMI(personData[i, 0], personData[i, 1]);
            bmiStatuses[i] = DetermineBMIStatus(personData[i, 2]);
        }

        // Display the results
        Console.WriteLine("\nPerson\tWeight (kg)\tHeight (cm)\tBMI\t\tStatus");
        for (int i = 0; i < teamSize; i++)
        {
            Console.WriteLine($"{i + 1}\t{personData[i, 0]}\t\t{personData[i, 1]}\t\t{personData[i, 2]:F2}\t{bmiStatuses[i]}");
        }
    }

    // Method to calculate BMI
    static double CalculateBMI(double weight, double heightCm)
    {
        double heightM = heightCm / 100; // Convert height to meters
        return weight / (heightM * heightM);
    }

    // Method to determine BMI status
    static string DetermineBMIStatus(double bmi)
    {
        if (bmi <= 18.4)
            return "Underweight";
        else if (bmi >= 18.5 && bmi <= 24.9)
            return "Normal";
        else if (bmi >= 25.0 && bmi <= 39.9)
            return "Overweight";
        else
            return "Obese";
    }
}
