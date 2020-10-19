using System.Collections.Generic;
namespace LING
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book()
                {
                    Title = "C# fundamentals",
                    Price = 8
                },
                new Book()
                {
                    Title = "C# intermediate",
                    Price = 5.4f
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
