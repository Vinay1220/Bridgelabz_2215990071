using System;

class Book
{
    private static string LibraryName = "GLA Central Library";
    private readonly int ISBN;
    private string Title;
    private string Author;

    public Book(int ISBN, string Title, string Author)
    {
        this.ISBN = ISBN;
        this.Title = Title;
        this.Author = Author;
    }

    public void DisplayBookDetails()
    {
        if (this is Book)
        {
            Console.WriteLine("Library: " + LibraryName);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
        }
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book(12345, "C# Programming", "Vinay Pal");
        book1.DisplayBookDetails();
        
        Book.DisplayLibraryName();
    }
}
