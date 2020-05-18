using System;

namespace learn_nullable_types_and_dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2000, 10, 20);
            DateTime? date2 = null;

            if (date != null)
                date = date.GetValueOrDefault();

            else
                date = DateTime.Now;

            Console.WriteLine("date: " + date);

            // ternary operator
            DateTime date3 = (date2 != null) ? date2.GetValueOrDefault() : DateTime.Today;
            Console.WriteLine("date3: " + date3);

            // using coalescing operator
            date2 = date2 ?? DateTime.Now;
            Console.WriteLine("date2: " + date2);

        }
    }
}
