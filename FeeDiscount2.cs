using System;

class FeeDiscount2
{
    static void Main()
    {
        // Variables for fee and discount percentage
        double fee, discountPercent, discountAmount, finalFee;

        // user input
        Console.WriteLine("Enter the student fee (in INR):");
        fee = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the university discount percentage:");
        discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate discount amount
        discountAmount = (fee * discountPercent) / 100;

        // Calculate final fee after discount
        finalFee = fee - discountAmount;

        // Output the results in the specified format
        Console.WriteLine("The discount amount is INR " + discountAmount + " and the final discounted fee is INR " + finalFee);
    }
}
