using System.Collections.Generic;
namespace learn_class_extension
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
