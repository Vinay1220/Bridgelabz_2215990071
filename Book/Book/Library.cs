using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Book Not Found.");
            }
        }

        public void ModifyBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                Console.Write("Enter New Title: ");
                book.Title = Console.ReadLine();
                Console.Write("Enter New Author: ");
                book.Author = Console.ReadLine();

                Console.WriteLine("Book Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Book Not Found.");
            }
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No Books Available.");
                return;
            }

            Console.WriteLine("\nLibrary Books:");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}
