#region 9st answer
/*Write a method PrintFirstBook() that prints the first book in the books array. 
*If the array is empty,use return to exit the method early instead of printing anything.*/
#endregion
using System;

namespace MyApp
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            PrintFirstBook(books);
        }

        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }
            Console.WriteLine(books[0]);
        }
    }
}