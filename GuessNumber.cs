using System;

class GuessNumber
{
    static void Main(String[] args)
    {
        Console.WriteLine("Think of a number between 1 and 100, and I will try to guess it!");
        PlayGame();
    }

    static void PlayGame()
    {
        int min = 1; // Lower bound
        int max = 100; // Upper bound
        string feedback;

        while (true)
        {
            int guess = (min + max) / 2;
            Console.WriteLine("Is your number " + guess + "? (Enter 'high', 'low', or 'correct')");

            feedback = GetUserFeedback();

            if (feedback == "correct")
            {
                Console.WriteLine("I guessed your number: " + guess );
                break;
            }
            else if (feedback == "low")
            {
                min = guess + 1;
            }
            else if (feedback == "high")
            {
                max = guess - 1;
            }
        }
    }

    static string GetUserFeedback()
	{
		string input;
		while (true)
		{
			input = Console.ReadLine().Trim().ToLower();
			if (input == "low" || input == "high" || input == "correct")
			{
				return input;
			}
			Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
		}
	}

}
