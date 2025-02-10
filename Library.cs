using System;
using System.Collections.Generic;

// Abstract class LibraryItem
abstract class LibraryItem
{
    private string itemId;
    private string title;
    private string author;
    protected bool isBorrowed;

    public string ItemId { get { return itemId; } }
    public string Title { get { return title; } }
    public string Author { get { return author; } }
    public bool IsBorrowed { get { return isBorrowed; } }

    public LibraryItem(string id, string title, string author)
    {
        this.itemId = id;
        this.title = title;
        this.author = author;
        this.isBorrowed = false;
    }

    public abstract int GetLoanDuration();

    public virtual void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Loan Duration: " + GetLoanDuration() + " days");
        Console.WriteLine("Borrowed: " + (isBorrowed ? "Yes" : "No"));
    }
}

// Interface for reservable items
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Book Class
class Book : LibraryItem, IReservable
{
    public Book(string id, string title, string author) 
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // 2 weeks loan duration
    }

    public void ReserveItem()
    {
        if (!isBorrowed)
        {
            isBorrowed = true;
            Console.WriteLine(Title + " has been reserved.");
        }
        else
        {
            Console.WriteLine(Title + " is already borrowed.");
        }
    }

    public bool CheckAvailability()
    {
        return !isBorrowed;
    }
}

// Magazine Class
class Magazine : LibraryItem
{
    public Magazine(string id, string title, string author) 
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // 1 week loan duration
    }
}

// DVD Class
class DVD : LibraryItem, IReservable
{
    private double duration; // in hours

    public DVD(string id, string title, string author, double duration) 
        : base(id, title, author)
    {
        this.duration = duration;
    }

    public override int GetLoanDuration()
    {
        return 3; // 3-day loan duration
    }

    public void ReserveItem()
    {
        if (!isBorrowed)
        {
            isBorrowed = true;
            Console.WriteLine(Title + " has been reserved.");
        }
        else
        {
            Console.WriteLine(Title + " is already borrowed.");
        }
    }

    public bool CheckAvailability()
    {
        return !isBorrowed;
    }
}

// Main Program
class Program
{
    static void ProcessLibraryItems(List<LibraryItem> items)
    {
        foreach (LibraryItem item in items)
        {
            item.GetItemDetails();
            
            // ✅ Fix: Use "as" operator to declare reservableItem properly
            IReservable reservableItem = item as IReservable;
            if (reservableItem != null)
            {
                Console.WriteLine("Available for reservation: " + (reservableItem.CheckAvailability() ? "Yes" : "No"));
            }

            Console.WriteLine("----------------------");
        }
    }

    static void Main()
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>();

        Book book1 = new Book("B001", "The C# Programming Guide", "John Doe");
        Magazine mag1 = new Magazine("M001", "Tech Today", "Jane Smith");
        DVD dvd1 = new DVD("D001", "Learn C# in 10 Hours", "Mark Spencer", 2.5);

        libraryItems.Add(book1);
        libraryItems.Add(mag1);
        libraryItems.Add(dvd1);

        ProcessLibraryItems(libraryItems);

        // Reserving items
        book1.ReserveItem();
        dvd1.ReserveItem();

        Console.WriteLine("\nAfter Reservations:");
        ProcessLibraryItems(libraryItems);
    }
}
