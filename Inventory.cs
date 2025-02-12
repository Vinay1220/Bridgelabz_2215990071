using System;

class InventoryItem
{
    public string ItemName;
    public int ItemID;
    public int Quantity;
    public double Price;
    public InventoryItem Next;

    public InventoryItem(string itemName, int itemID, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemID;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class InventoryManagement
{
    private InventoryItem head;

    public void AddFirst(string itemName, int itemID, int quantity, double price)
    {
        InventoryItem newItem = new InventoryItem(itemName, itemID, quantity, price);
        newItem.Next = head;
        head = newItem;
    }

    public void AddLast(string itemName, int itemID, int quantity, double price)
    {
        InventoryItem newItem = new InventoryItem(itemName, itemID, quantity, price);
        if (head == null)
        {
            head = newItem;
            return;
        }
        InventoryItem temp = head;
        while (temp.Next != null)
            temp = temp.Next;
        temp.Next = newItem;
    }

    public void AddAtPosition(string itemName, int itemID, int quantity, double price, int position)
    {
        InventoryItem newItem = new InventoryItem(itemName, itemID, quantity, price);
        if (position == 1)
        {
            newItem.Next = head;
            head = newItem;
            return;
        }
        InventoryItem temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.Next;
        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        newItem.Next = temp.Next;
        temp.Next = newItem;
    }

    public void RemoveItem(int itemID)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        if (head.ItemID == itemID)
        {
            head = head.Next;
            return;
        }
        InventoryItem temp = head, prev = null;
        while (temp != null && temp.ItemID != itemID)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }
        prev.Next = temp.Next;
    }

    public void UpdateQuantity(int itemID, int newQuantity)
    {
        InventoryItem temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                temp.Quantity = newQuantity;
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void SearchByID(int itemID)
    {
        InventoryItem temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                Console.WriteLine("Item Found: " + temp.ItemName + ", ID: " + temp.ItemID + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void SearchByName(string itemName)
    {
        InventoryItem temp = head;
        while (temp != null)
        {
            if (temp.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Item Found: " + temp.ItemName + ", ID: " + temp.ItemID + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void CalculateTotalValue()
    {
        double totalValue = 0;
        InventoryItem temp = head;
        while (temp != null)
        {
            totalValue += temp.Quantity * temp.Price;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value: " + totalValue);
    }
}

class Program
{
    static void Main()
    {
        InventoryManagement inventory = new InventoryManagement();
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nInventory Management System:");
            Console.WriteLine("1 - Add Item at Beginning");
            Console.WriteLine("2 - Add Item at End");
            Console.WriteLine("3 - Add Item at Position");
            Console.WriteLine("4 - Remove Item by ID");
            Console.WriteLine("5 - Update Item Quantity");
            Console.WriteLine("6 - Search Item by ID");
            Console.WriteLine("7 - Search Item by Name");
            Console.WriteLine("8 - Calculate Total Inventory Value");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    running = false;
                    break;
                case 1:
                case 2:
                case 3:
                    Console.Write("Enter Item Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Item ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double price = double.Parse(Console.ReadLine());
                    if (choice == 1)
                        inventory.AddFirst(name, id, qty, price);
                    else if (choice == 2)
                        inventory.AddLast(name, id, qty, price);
                    else
                    {
                        Console.Write("Enter Position: ");
                        int pos = int.Parse(Console.ReadLine());
                        inventory.AddAtPosition(name, id, qty, price, pos);
                    }
                    break;
                case 4:
                    Console.Write("Enter Item ID to Remove: ");
                    id = int.Parse(Console.ReadLine());
                    inventory.RemoveItem(id);
                    break;
                case 5:
                    Console.Write("Enter Item ID to Update Quantity: ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Quantity: ");
                    qty = int.Parse(Console.ReadLine());
                    inventory.UpdateQuantity(id, qty);
                    break;
                case 6:
                    Console.Write("Enter Item ID to Search: ");
                    id = int.Parse(Console.ReadLine());
                    inventory.SearchByID(id);
                    break;
                case 7:
                    Console.Write("Enter Item Name to Search: ");
                    name = Console.ReadLine();
                    inventory.SearchByName(name);
                    break;
                case 8:
                    inventory.CalculateTotalValue();
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
