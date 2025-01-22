using System;

class TotalPrice
{
    static void Main()
    {
        // Variables for unit price and quantity
        double unitPrice, totalPrice;
        int quantity;

        // Input for unit price and quantity
        Console.WriteLine("Enter the unit price of the item (in INR):");
        unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the quantity to be bought:");
        quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price
        totalPrice = unitPrice * quantity;

        // Output
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
    }
}
