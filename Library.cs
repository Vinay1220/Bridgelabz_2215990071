using System;

class BookNode
{
    public string BookTitle;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;
    public BookNode Next;
    public BookNode Prev;

    public BookNode(string bookTitle, string author, string genre, int bookID, bool isAvailable)
    {
        BookTitle = bookTitle;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

class Library
{
    private BookNode head;
    private BookNode tail;
    private int count = 0;

    public void AddFirst(string bookTitle, string author, string genre, int bookID, bool isAvailable)
    {
        BookNode newBook = new BookNode(bookTitle, author, genre, bookID, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        count++;
    }

    public void AddLast(string bookTitle, string author, string genre, int bookID, bool isAvailable)
    {
        BookNode newBook = new BookNode(bookTitle, author, genre, bookID, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        count++;
    }

    public void AddAtPosition(string bookTitle, string author, string genre, int bookID, bool isAvailable, int position)
    {
        if (position < 1 || position > count + 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddFirst(bookTitle, author, genre, bookID, isAvailable);
            return;
        }

        if (position == count + 1)
        {
            AddLast(bookTitle, author, genre, bookID, isAvailable);
            return;
        }

        BookNode newBook = new BookNode(bookTitle, author, genre, bookID, isAvailable);
        BookNode temp = head;
        for (int i = 1; i < position - 1; i++)
        {
            temp = temp.Next;
        }

        newBook.Next = temp.Next;
        newBook.Prev = temp;
        temp.Next.Prev = newBook;
        temp.Next = newBook;
        count++;
    }

    public void RemoveBook(int bookID)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        BookNode temp = head;

        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp == head)
        {
            head = head.Next;
            if (head != null)
                head.Prev = null;
        }
        else if (temp == tail)
        {
            tail = tail.Prev;
            tail.Next = null;
        }
        else
        {
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }

        count--;
        Console.WriteLine("Book removed successfully.");
    }

    public void SearchBookByTitleOrAuthor(string query)
    {
        BookNode temp = head;
        bool found = false;
        
        while (temp != null)
        {
            if (temp.BookTitle.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                temp.Author.Equals(query, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Book Found - Title: " + temp.BookTitle + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", ID: " + temp.BookID + ", Available: " + (temp.IsAvailable ? "Yes" : "No"));
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void UpdateAvailability(int bookID, bool availability)
    {
        BookNode temp = head;

        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        temp.IsAvailable = availability;
        Console.WriteLine("Availability updated successfully.");
    }

    public void DisplayBooksForward()
    {
        if (head == null)
        {
            Console.WriteLine("No books in the library.");
            return;
        }

        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.BookTitle + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", ID: " + temp.BookID + ", Available: " + (temp.IsAvailable ? "Yes" : "No"));
            temp = temp.Next;
        }
    }

    public void DisplayBooksReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No books in the library.");
            return;
        }

        BookNode temp = tail;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.BookTitle + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", ID: " + temp.BookID + ", Available: " + (temp.IsAvailable ? "Yes" : "No"));
            temp = temp.Prev;
        }
    }

    public void CountBooks()
    {
        Console.WriteLine("Total books in library: " + count);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nLibrary Management Menu:");
            Console.WriteLine("1 - Add Book at Beginning");
            Console.WriteLine("2 - Add Book at End");
            Console.WriteLine("3 - Add Book at Position");
            Console.WriteLine("4 - Remove Book by ID");
            Console.WriteLine("5 - Search Book by Title or Author");
            Console.WriteLine("6 - Update Book Availability");
            Console.WriteLine("7 - Display All Books (Forward)");
            Console.WriteLine("8 - Display All Books (Reverse)");
            Console.WriteLine("9 - Count Total Books");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 0:
                    running = false;
                    break;

                case 1:
                case 2:
                case 3:
                    Console.Write("Enter Book Title: ");
                    string bookTitle = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();
                    Console.Write("Enter Book ID: ");
                    int bookID = int.Parse(Console.ReadLine());
                    Console.Write("Is the book available? (true/false): ");
                    bool isAvailable = bool.Parse(Console.ReadLine());

                    if (choice == 1)
                        library.AddFirst(bookTitle, author, genre, bookID, isAvailable);
                    else if (choice == 2)
                        library.AddLast(bookTitle, author, genre, bookID, isAvailable);
                    else
                    {
                        Console.Write("Enter Position: ");
                        int position = int.Parse(Console.ReadLine());
                        library.AddAtPosition(bookTitle, author, genre, bookID, isAvailable, position);
                    }
                    break;

                case 4:
                    Console.Write("Enter Book ID to Remove: ");
                    int removeID = int.Parse(Console.ReadLine());
                    library.RemoveBook(removeID);
                    break;

                case 5:
                    Console.Write("Enter Book Title or Author to Search: ");
                    string query = Console.ReadLine();
                    library.SearchBookByTitleOrAuthor(query);
                    break;

                case 6:
                    Console.Write("Enter Book ID to Update Availability: ");
                    int updateID = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Availability (true/false): ");
                    bool availability = bool.Parse(Console.ReadLine());
                    library.UpdateAvailability(updateID, availability);
                    break;

                case 7:
                    library.DisplayBooksForward();
                    break;

                case 8:
                    library.DisplayBooksReverse();
                    break;

                case 9:
                    library.CountBooks();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
