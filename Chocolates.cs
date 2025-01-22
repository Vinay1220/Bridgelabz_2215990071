using System;

class Chocolates
{
    static void Main()
    {
        // Variables for chocolates and children
        int numberOfChocolates, numberOfChildren;

        // Input for number of chocolates and children
        Console.WriteLine("Enter the number of chocolates:");
        numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of children:");
        numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate chocolates per child and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Output the result
        Console.WriteLine("The number of chocolates each child gets is "+chocolatesPerChild+" and the number of remaining chocolates is "+remainingChocolates);
    }
}
