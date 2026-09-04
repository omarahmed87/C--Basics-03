#region 5st answer
/*Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
 * , use a for loop to print each book with its position number, like 1. Clean Code.*/
#endregion
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i =0; i<books.Length; i++)
            {
                Console.WriteLine($" {i}. {books[i]}");
            }
        }
    }
}