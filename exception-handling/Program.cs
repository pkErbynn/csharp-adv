using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calc = new Calculator();
                var result = calc.Divide(3, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot be divideb by zero");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Error occured with arithmetic");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops!....something went wrong..." + ex.Message);
            }
          
        }
    }
}
