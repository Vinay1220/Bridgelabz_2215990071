using System;

class LibBooking
{
    private string title;
    private string author;
    private double price;
    private bool isAvailable;

    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = true;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine(title + " has been borrowed.");
        }
        else
        {
            Console.WriteLine(title + " is already borrowed.");
        }
    }

    public void Display()
    {
        Console.WriteLine("Title: " + title + ", Author: " + author + ", Price: " + price + ", Available: " + isAvailable);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Book book1 = new Book("C# Basics", "John Smith", 25.99);
        book1.Display();
        book1.BorrowBook();
        book1.Display();
    }
}
