using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!....");
            var processor = new PhotoProcessor();

            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemovereFilter;
            filterHandler += AddCanve;

            processor.Process("my path", filterHandler);

            Func<int, int> res = number => number * number;
            Console.WriteLine(res(4));
       }

        static void RemovereFilter(Photo photo)
        {
            Console.WriteLine("Apply red eye filtter");
        }

        static void AddCanve(Photo photo)
        {
            Console.WriteLine("apply canvas");
        }
    }
}
