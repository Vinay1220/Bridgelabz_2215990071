using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException() : base("Age must be 18 or above") { }
}

class Program
{
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException();
        }
        Console.WriteLine("Access granted!");
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            ValidateAge(age);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric age.");
        }
    }
}
