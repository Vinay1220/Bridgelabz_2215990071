using System;

class LibrarySys
{
    public string ISBN;       // Public: Accessible anywhere
    protected string title;   // Protected: Accessible in subclass
    private string author;    // Private: Only accessible within the class

    // Constructor
    public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // Public method to set author
    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

    // Public method to get author
    public string GetAuthor()
    {
        return author;
    }

    public void DisplayBook()
    {
        Console.WriteLine("ISBN: " + ISBN + ", Title: " + title + ", Author: " + author);
    }
}

// Subclass demonstrating access to ISBN and title
class EBook : Book
{
    private string fileFormat;

    public EBook(string ISBN, string title, string author, string fileFormat)
        : base(ISBN, title, author)
    {
        this.fileFormat = fileFormat;
    }

    public void DisplayEBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN + ", Title: " + title + ", Format: " + fileFormat);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Book book1 = new Book("978-3-16-148410-0", "C# Basics", "Vinay");
        book1.DisplayBook();
        book1.SetAuthor("Vinay Pal");
        Console.WriteLine("Updated Author: " + book1.GetAuthor());

        EBook eBook1 = new EBook("978-1-23-456789-0", "Advanced C#", "sayendra", "PDF");
        eBook1.DisplayEBookDetails();
    }
}
