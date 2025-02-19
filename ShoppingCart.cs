using System;
using System.Collections.Generic;

public class ShoppingCart
{
    // Dictionary to store product prices (product name -> price)
    private Dictionary<string, double> productPrices = new Dictionary<string, double>();

    // LinkedList to maintain the order of products added to the cart
    private LinkedList<string> productOrder = new LinkedList<string>();

    // Method to add a product to the cart
    public void AddProduct(string productName, double price)
    {
        if (!productPrices.ContainsKey(productName))
        {
            productPrices[productName] = price;
            productOrder.AddLast(productName);  // Maintain the order in which the product was added
        }
        else
        {
            Console.WriteLine("Product already exists in the cart.");
        }
    }

    // Method to display the products sorted by price
    public void DisplaySortedProducts()
    {
        // SortedDictionary to sort products by their price
        var sortedProducts = new SortedDictionary<double, List<string>>();

        foreach (var product in productPrices)
        {
            if (!sortedProducts.ContainsKey(product.Value))
            {
                sortedProducts[product.Value] = new List<string>();
            }
            sortedProducts[product.Value].Add(product.Key);
        }

        Console.WriteLine("Products sorted by price:");
        foreach (var price in sortedProducts)
        {
            foreach (var productName in price.Value)
            {
                Console.WriteLine("Product: " + productName + ", Price: " + price.Key);
            }
        }
    }

    // Method to display the products in the order they were added
    public void DisplayProductsInOrder()
    {
        Console.WriteLine("Products in the order they were added:");
        foreach (var product in productOrder)
        {
            Console.WriteLine("Product: " + product + ", Price: " + productPrices[product]);
        }
    }
}

// Test the ShoppingCart
public class Program
{
    public static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        // Adding products to the cart
        cart.AddProduct("Laptop", 1200.50);
        cart.AddProduct("Smartphone", 699.99);
        cart.AddProduct("Headphones", 199.99);
        cart.AddProduct("Tablet", 399.49);

        // Display the products sorted by price
        cart.DisplaySortedProducts();

        // Display the products in the order they were added
        Console.WriteLine("\nOrder of products added:");
        cart.DisplayProductsInOrder();
    }
}