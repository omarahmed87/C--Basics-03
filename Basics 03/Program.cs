#region 8st answer
/*Using the same books array, print every title except "The Pragmatic Programmer
 * " (skip it with continue, don't stop the loop).*/
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
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
        }
    }
}