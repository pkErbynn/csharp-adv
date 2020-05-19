﻿using System;
using System.IO;
namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Calculator calc = new Calculator();
            //    var result = calc.Divide(3, 0);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot be divided by zero");
            //}
            //catch (ArithmeticException)
            //{
            //    Console.WriteLine("Error occured with arithmetic");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Oops!....something went wrong..." + ex.Message);
            //}

            var streamReader = new StreamReader(@"C:\Users\Mr. Erbynn\source\repos\learn\exception-handling\file.zip");
            try
            {
                var content = streamReader.ReadToEnd();
                throw new Exception("Oops!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, expected error occured...");
            }
            finally
            {
                streamReader.Dispose();
            }
          
        }
    }
}
