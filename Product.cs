using System;

class Product
{
    private static double Discount = 10.0;
    private readonly int ProductID;
    private string ProductName;
    private double Price;
    private int Quantity;

    public Product(int ProductID, string ProductName, double Price, int Quantity)
    {
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
    }

    public void DisplayProductDetails()
    {
        if (this is Product)
        {
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Discount: " + Discount + "%");
        }
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine("New Discount: " + Discount + "%");
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Product(101, "Laptop", 50000, 2);
        product1.DisplayProductDetails();
        
        Product.UpdateDiscount(15);
    }
}
