using System;

class countdownUsinForLoop
{
    static void Main()
    {
        Console.WriteLine("Enter a number to start countdown:");
        int counter = int.Parse(Console.ReadLine());

        for (int i = counter; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Liftoff!");
    }
}
