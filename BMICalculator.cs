using System;

class BMICalculator
{
    static void Main()
    {
        // user to enter the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        // Arrays to store weight, height, BMI, and weight status
        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] weightStatuses = new string[numberOfPersons];

        // Input weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.Write("Enter weight (kg) of person " + (i + 1) + ": ");
            weights[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter height (m) of person " + (i + 1) + ": ");
            heights[i] = double.Parse(Console.ReadLine());

            // Calculate BMI
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            // Determine weight status
            weightStatuses[i] = GetWeightStatus(bmis[i]);
        }

        // Display the results
        Console.WriteLine("\nHeight\tWeight\tBMI\tStatus");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine(heights[i].ToString("0.00") + "\t" + weights[i].ToString("0.00") + "\t" + bmis[i].ToString("0.00") + "\t" + weightStatuses[i]);
        }
    }

    // Method to get weight status based on BMI
    static string GetWeightStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        if (bmi < 24.9) return "Normal weight";
        if (bmi < 29.9) return "Overweight";
        return "Obese";
    }
}
