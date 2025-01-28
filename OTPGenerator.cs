using System;

class OTPGenerator
{
    // Method to generate a 6-digit OTP number
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000); // Generate a number between 100000 and 999999
    }

    // Method to ensure that the OTP numbers generated are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        HashSet<int> otpSet = new HashSet<int>(); // Use a HashSet to track unique OTPs

        foreach (int otp in otps)
        {
            if (!otpSet.Add(otp)) // Try to add the OTP to the set
            {
                return false; // If it already exists, return false
            }
        }

        return true; // All OTPs are unique
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] otps = new int[10]; // Array to store 10 OTP numbers

        // Generate 10 OTP numbers
        for (int i = 0; i < 10; i++)
        {
            otps[i] = OTPGenerator.GenerateOTP();
        }

        // Display the generated OTPs
        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }

        // Check if the OTPs are unique
        bool areUnique = OTPGenerator.AreOTPsUnique(otps);
        Console.WriteLine("Are all OTPs unique? " + (areUnique ? "Yes" : "No"));
    }
}