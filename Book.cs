using System;

class Book
{
    // Attributes
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Constructor to initialize attributes
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: $" + Price.ToString("F2"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Take input for book details from the user
        Console.WriteLine("Enter the book title:");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the book author:");
        string author = Console.ReadLine();

        Console.WriteLine("Enter the book price:");
        double price;
        while (!double.TryParse(Console.ReadLine(), out price) || price < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive price:");
        }

        // Create a Book object
        Book book = new Book(title, author, price);

        // Display the book details
        book.DisplayDetails();
    }
}
