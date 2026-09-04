#region 6st answer
/*Using the same books array, use a while loop to print every book title. */
#endregion
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int i = 0;
            while(i<books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }
        }
    }
}