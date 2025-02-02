using System;

class Book
{
    private string title;
    private string author;
    private double price;

    // Default constructor
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        price = 0.0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void Display()
    {
        Console.WriteLine("Title: " + title + ", Author: " + author + ", Price: " + price);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Book defaultBook = new Book();
        defaultBook.Display();

        Book customBook = new Book("C# Programming", "John Doe", 39.99);
        customBook.Display();
    }
}
