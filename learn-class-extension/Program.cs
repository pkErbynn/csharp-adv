using System;
using System.Collections.Generic;

namespace learn_class_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = new List<Book>();
            foreach(var book in books)
            {
                if (book.Price < 9)
                    cheapBooks.Add(book);
            }

            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book()
                {
                    Title = "C# fundamentals",
                    Price = 5
                },
                new Book()
                {
                    Title = "C# intermediate",
                    Price = 8.4f
                },
                new Book()
                {
                    Title = "C# Advanced",
                    Price = 9.99f
                },
                new Book()
                {
                    Title = "C# To the next level",
                    Price = 10.5f
                }
            };
        }
    }
}
