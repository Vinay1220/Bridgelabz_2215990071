using System;
using System.Collections.Generic;

// Abstract class FoodItem
abstract class FoodItem
{
    private string itemName;
    protected double price;
    protected int quantity;

    public string ItemName { get { return itemName; } }
    public double Price { get { return price; } }
    public int Quantity { get { return quantity; } }

    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine("Item: " + itemName);
        Console.WriteLine("Price per unit: $" + price);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Total Price: $" + CalculateTotalPrice());
    }
}

// Interface for Discountable items
interface IDiscountable
{
    void ApplyDiscount(double discountPercentage);
    string GetDiscountDetails();
}

// VegItem Class
class VegItem : FoodItem, IDiscountable
{
    private double discountApplied = 0;

    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (price * quantity) - discountApplied;
    }

    public void ApplyDiscount(double discountPercentage)
    {
        discountApplied = (price * quantity) * (discountPercentage / 100);
    }

    public string GetDiscountDetails()
    {
        return "Discount Applied: $" + discountApplied;
    }
}

// NonVegItem Class
class NonVegItem : FoodItem, IDiscountable
{
    private double additionalCharge = 2.0; // Extra charge for non-veg items
    private double discountApplied = 0;

    public NonVegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return ((price * quantity) + additionalCharge) - discountApplied;
    }

    public void ApplyDiscount(double discountPercentage)
    {
        discountApplied = (price * quantity) * (discountPercentage / 100);
    }

    public string GetDiscountDetails()
    {
        return "Discount Applied: $" + discountApplied;
    }
}

// Main Program
class Program
{
    static void ProcessOrder(List<FoodItem> foodItems)
    {
        foreach (FoodItem item in foodItems)
        {
            item.GetItemDetails();
            
            // Handle discountable items dynamically
            IDiscountable discountableItem = item as IDiscountable;
            if (discountableItem != null)
            {
                Console.WriteLine(discountableItem.GetDiscountDetails());
            }

            Console.WriteLine("----------------------");
        }
    }

    static void Main()
    {
        List<FoodItem> foodOrder = new List<FoodItem>();

        VegItem veg1 = new VegItem("Paneer Tikka", 8.99, 2);
        NonVegItem nonVeg1 = new NonVegItem("Chicken Biryani", 12.50, 1);

        // Applying discount
        veg1.ApplyDiscount(10); // 10% discount
        nonVeg1.ApplyDiscount(5); // 5% discount

        foodOrder.Add(veg1);
        foodOrder.Add(nonVeg1);

        ProcessOrder(foodOrder);
    }
}
