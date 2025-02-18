using System;
using System.Collections.Generic;

// Base class for warehouse items
abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}

// Derived classes for specific items
class Electronics : WarehouseItem
{
    public string Brand { get; set; }

    public Electronics(string name, double price, string brand) : base(name, price)
    {
        Brand = brand;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Electronics: " + Name + " | Price: " + Price + " | Brand: " + Brand);
    }
}

class Groceries : WarehouseItem
{
    public string ExpiryDate { get; set; }

    public Groceries(string name, double price, string expiryDate) : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Groceries: " + Name + " | Price: " + Price + " | Expiry Date: " + ExpiryDate);
    }
}

class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material) : base(name, price)
    {
        Material = material;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Furniture: " + Name + " | Price: " + Price + " | Material: " + Material);
    }
}

// Generic storage class for warehouse items
class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public IReadOnlyList<T> GetItems()
    {
        return items.AsReadOnly();
    }

    public void DisplayAllItems()
    {
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop", 800, "Dell"));
        electronicsStorage.AddItem(new Electronics("Smartphone", 500, "Samsung"));

        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        groceriesStorage.AddItem(new Groceries("Milk", 2.5, "2025-06-01"));
        groceriesStorage.AddItem(new Groceries("Bread", 1.5, "2025-02-25"));

        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture("Chair", 50, "Wood"));
        furnitureStorage.AddItem(new Furniture("Table", 100, "Metal"));

        Console.WriteLine("Electronics:");
        electronicsStorage.DisplayAllItems();

        Console.WriteLine("\nGroceries:");
        groceriesStorage.DisplayAllItems();

        Console.WriteLine("\nFurniture:");
        furnitureStorage.DisplayAllItems();
    }
}
