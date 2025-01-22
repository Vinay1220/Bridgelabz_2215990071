using System;

class FeeDiscount
{
    static void Main(string[] args)
    {
        // fee and discount percentage
        double fee = 125000;
        double discountPercent = 10;

        // Calculate the discount amount
        double discount = (fee * discountPercent) / 100;

        // Calculate the final fee after discount
        double discountedFee = fee - discount;

        // Output the results
        Console.WriteLine("The discount amount is INR "+discount+" and the final discounted fee is INR "+discountedFee);
    }
}
