using System;
using System.Collections.Generic;

// Abstract class Product
abstract class Product
{
    private int productId;
    private string name;
    protected double price;

    public int ProductId { get { return productId; } }
    public string Name { get { return name; } }
    public double Price { get { return price; } }

    public Product(int id, string productName, double productPrice)
    {
        productId = id;
        name = productName;
        price = productPrice;
    }

    public abstract double CalculateDiscount();

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Discount: " + CalculateDiscount());
    }
}

// Interface for tax calculation
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics category
class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.10; // 10% discount
    }

    public double CalculateTax()
    {
        return price * 0.18; // 18% tax
    }

    public string GetTaxDetails()
    {
        return "Tax on Electronics: 18%";
    }
}

// Clothing category
class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.20; // 20% discount
    }

    public double CalculateTax()
    {
        return price * 0.05; // 5% tax
    }

    public string GetTaxDetails()
    {
        return "Tax on Clothing: 5%";
    }
}

// Groceries category (No tax, different discount)
class Groceries : Product
{
    public Groceries(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.05; // 5% discount
    }
}

// Main Program
class Program
{
    static void CalculateFinalPrice(List<Product> products)
    {
        foreach (Product product in products)
{
    double discount = product.CalculateDiscount();
    double tax = 0;

    if (product is ITaxable)
    {
        ITaxable taxableProduct = (ITaxable)product;
        tax = taxableProduct.CalculateTax();
        Console.WriteLine(taxableProduct.GetTaxDetails());
    }

    double finalPrice = product.Price + tax - discount;
    product.DisplayDetails();
    Console.WriteLine("Final Price: " + finalPrice);
    Console.WriteLine("----------------------");
}

    }

    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Electronics(1, "Laptop", 50000));
        products.Add(new Clothing(2, "T-Shirt", 1000));
        products.Add(new Groceries(3, "Apple", 200));

        CalculateFinalPrice(products);
    }
}
