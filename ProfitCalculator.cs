using System;

class ProfitCalculator
{
    static void Main(string[] args)
    {
        // Cost price and selling price
        double costPrice = 129.0;
        double sellingPrice = 191.0;

        // Calculate profit or loss
        double profit = sellingPrice - costPrice;
        double percentage = (profit / costPrice) * 100;
		
		//Total profit and loss percentage
		 Console.WriteLine("The Cost Price is INR "+ costPrice+" and "+"Selling Price is INR "+sellingPrice+"\n"+"The Profit is INR "+profit+" and "+"the Profit Percentage is "+percentage);
	}
}	