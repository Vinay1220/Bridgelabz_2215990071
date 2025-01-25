using System;

class BMICalculator2DArray
{
    static void Main()
    {
        // user to enter the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        // Create a 2D array to store height, weight, and BMI for all persons
        double[,] personData = new double[numberOfPersons, 3]; // [Person][0=Weight, 1=Height, 2=BMI]
        string[] weightStatus = new string[numberOfPersons]; // Array to store the weight status of each person

        // Input height and weight for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1) + ":");

            // Input weight with validation
            Console.Write("Enter weight (kg): ");
            personData[i, 0] = GetValidInput();

            // Input height with validation
            Console.Write("Enter height (m): ");
            personData[i, 1] = GetValidInput();

            // Calculate BMI: BMI = weight / (height^2)
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);

            // Determine the weight status based on BMI
            weightStatus[i] = GetWeightStatus(personData[i, 2]);
        }

        // Display the height, weight, BMI, and weight status for all persons
        Console.WriteLine("\nHeight (m)\tWeight (kg)\tBMI\t\tStatus");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine(personData[i, 1].ToString("0.00") + "\t\t" +
                              personData[i, 0].ToString("0.00") + "\t\t" +
                              personData[i, 2].ToString("0.00") + "\t\t" +
                              weightStatus[i]);
        }
    }

    // Method to ensure valid (positive) input for height and weight
    static double GetValidInput()
    {
        double value;
        while (true)
        {
            value = double.Parse(Console.ReadLine());
            if (value > 0) return value; // Valid value
            Console.Write("Invalid input. Please enter a positive value: ");
        }
    }

    // Method to determine weight status based on BMI
    static string GetWeightStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        if (bmi < 24.9) return "Normal weight";
        if (bmi < 29.9) return "Overweight";
        return "Obese";
    }
}
