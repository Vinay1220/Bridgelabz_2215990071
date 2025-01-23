using System;

class CountDown
{
    static void Main()
    {
        Console.WriteLine("Enter a number to start countdown:");
        int counter = int.Parse(Console.ReadLine());

        while (counter > 0)
        {
            Console.WriteLine(counter);
            counter--;
        }
        Console.WriteLine("Liftoff!");
    }
}
