using System;
using System.Collections.Generic;

// Interface for all products
interface IProduct
{
    string ProductName { get; }
    double Price { get; set; }
    void DisplayInfo();
}

// Base class for product categories
abstract class ProductCategory
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    protected ProductCategory(string name)
    {
        _name = name;
    }
}

// Derived product categories
class BookCategory : ProductCategory
{
    public BookCategory() : base("Books") { }
}

class ClothingCategory : ProductCategory
{
    public ClothingCategory() : base("Clothing") { }
}

// Generic product class implementing IProduct
class Product<T> : IProduct where T : ProductCategory
{
    private string _productName;
    private double _price;
    private T _category;

    public string ProductName
    {
        get { return _productName; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public T Category
    {
        get { return _category; }
    }

    public Product(string productName, double price, T category)
    {
        _productName = productName;
        _price = price;
        _category = category;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Product: " + ProductName + " | Price: " + Price + " | Category: " + Category.Name);
    }
}

// Marketplace class
class Marketplace
{
    private List<IProduct> products = new List<IProduct>();

    public void AddProduct(IProduct product)
    {
        products.Add(product);
    }

    public void DisplayAllProducts()
    {
        foreach (var product in products)
        {
            product.DisplayInfo();
        }
    }

    // Apply discount method
    public void ApplyDiscount(IProduct product, double percentage)
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine("Discount applied: " + product.ProductName + " | New Price: " + product.Price);
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Marketplace marketplace = new Marketplace();

        var book1 = new Product<BookCategory>("C# Programming", 40, new BookCategory());
        var book2 = new Product<BookCategory>("Design Patterns", 50, new BookCategory());

        var clothing1 = new Product<ClothingCategory>("T-Shirt", 20, new ClothingCategory());
        var clothing2 = new Product<ClothingCategory>("Jeans", 35, new ClothingCategory());

        marketplace.AddProduct(book1);
        marketplace.AddProduct(book2);
        marketplace.AddProduct(clothing1);
        marketplace.AddProduct(clothing2);

        Console.WriteLine("All Products:");
        marketplace.DisplayAllProducts();

        Console.WriteLine("\nApplying Discounts:");
        marketplace.ApplyDiscount(book1, 10);
        marketplace.ApplyDiscount(clothing1, 15);
    }
}
