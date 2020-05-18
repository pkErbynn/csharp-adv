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

            // above can be replaced by linq
            var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Price).Select(b => b.Title); // Select => map
             
            foreach(var book in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);  // only book titles
            }
        }
    }
}
