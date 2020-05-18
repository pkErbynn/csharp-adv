using System;
using System.Linq;
namespace learn_class_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = new List<Book>();
            //foreach(var book in books)
            //{
            //    if (book.Price < 9)
            //        cheapBooks.Add(book);
            //}

            // using LINQ Extention Methods
            var cheapBooks = books
                                                .Where(b => b.Price < 10)  // filter
                                                .OrderBy(b => b.Price)  // sort
                                                .Select(b => b.Title); //  map

            // using LINQ Query Operators
            var cheapBooks2 = 
                              from b in books
                              where b.Price < 10
                              orderby b.Title
                              select b;

            foreach (var book in cheapBooks2)
            {
                Console.WriteLine(book.Title + " " + book.Price);
                //Console.WriteLine(book);  // only book titles
            }
        }
    }
}
