#region 7st answer
/*Using the same books array, use a foreach loop to print every book title. */
#endregion
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
           
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}