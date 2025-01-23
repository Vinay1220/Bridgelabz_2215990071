using System;

class FirstSmallest
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        if (number1 < number2 && number1 < number3)
        {
            Console.WriteLine("Is the first number the smallest? Yes");
        }
        else
        {
            Console.WriteLine("Is the first number the smallest? No");
        }
    }
}
