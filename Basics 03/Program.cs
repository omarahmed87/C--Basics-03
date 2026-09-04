#region 4st answer
/*Given int pages = 464;, use the ternary operator to store "Long Book" or 
 * "Short Book"into a variable sizeLabel(same rule as question 8:long if pages > 300). */
#endregion
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int pages = 464;
            string sizeLable = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLable);

        }
    }
}