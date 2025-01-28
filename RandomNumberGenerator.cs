using System;

class RandomNumberGenerator
{
    // Method to generate an array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000); // Generate a random number between 1000 and 9999
        }

        return randomNumbers; // Return the array of random numbers
    }

    // Method to find the average, min, and max value of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        double average = 0;
        int min = numbers[0];
        int max = numbers[0];

        // Calculate sum, min, and max
        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        average /= numbers.Length; // Calculate the average

        return new double[] { average, min, max }; // Return average, min, and max
    }
}

class Program
{
    static void Main(string[] args)
    {
        RandomNumberGenerator rng = new RandomNumberGenerator();

        // Generate an array of 5 random 4-digit numbers
        int[] randomNumbers = rng.Generate4DigitRandomArray(5);

        // Display the generated random numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int number in randomNumbers)
        {
            Console.WriteLine(number);
        }

        // Find average, min, and max values
        double[] results = rng.FindAverageMinMax(randomNumbers);

        // Display the results
        Console.WriteLine($"Average: {results[0]}");
        Console.WriteLine($"Minimum: {results[1]}");
        Console.WriteLine($"Maximum: {results[2]}");
    }
}