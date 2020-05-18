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

            // using LINQ Query Operators
            var cheapBooks2 = 
                              from b in books
                              where b.Price < 10
                              orderby b.Title
                              select b;

            foreach (var book in cheapBooks2)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }


            // using LINQ Extention Methods
            var cheapBooks = books
                                                .Where(b => b.Price < 10)  // filter
                                                .OrderBy(b => b.Price)  // sort
                                                .Select(b => b.Title); //  map

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }


            // other useful filters
            var oneBook = books.SingleOrDefault(b =>b.Price == 8);  // Default => if not exist, return null
            Console.WriteLine(oneBook.Title);

            var oneBook2 = books.FirstOrDefault(b => b.Price != 30);
            Console.WriteLine(oneBook2.Title);

            var oneBook3 = books.LastOrDefault(b => b.Price != 30);
            Console.WriteLine(oneBook2.Title);

            var pageBooks = books.Skip(2).Take(2);  // skips first 2 and take the next 2....mostly for paging
            foreach (var pb in pageBooks)
            {
                Console.WriteLine("----------");
                Console.WriteLine(pb.Title);
            }


            // aggregate
            var count = books.Count();
            Console.WriteLine("count: " + count);

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine("max: " + maxPrice);

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine("min: " + minPrice);

            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine("sum: " + totalPrice);
        }
    }
}
