using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Modify Book");
                Console.WriteLine("4. Display Books");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        Book newBook = new Book(id, title, author);
                        library.AddBook(newBook);
                        Console.WriteLine("Book Added Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Book ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        library.RemoveBook(removeId);
                        break;

                    case 3:
                        Console.Write("Enter Book ID to modify: ");
                        int modifyId = int.Parse(Console.ReadLine());
                        library.ModifyBook(modifyId);
                        break;

                    case 4:
                        library.DisplayBooks();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
