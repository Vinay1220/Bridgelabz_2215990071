using System;

// Superclass: Book
public class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

// Subclass: Author (inherits from Book)
public class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Bio: " + Bio);
    }
}

// Main Class
public class Program
{
    public static void Main()
    {
        Author author1 = new Author("wings of fire", 1925, "A.P.G.Kalam", "Famous Indian.");
        author1.DisplayInfo();
    }
}
