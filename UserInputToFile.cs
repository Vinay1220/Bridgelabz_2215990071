using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        string filePath = "user_data.txt";

        try
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Enter your favorite programming language: ");
            string language = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Programming Language: " + language);
            }

            Console.WriteLine("User information saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
