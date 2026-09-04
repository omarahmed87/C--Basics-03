#region 1st answer
//Given int pages = 464;, write an if / else statement that prints "Long Book"
//if pages is greater than 300, otherwise prints "Short Book".   
#endregion
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = 464;
            if (pages >= 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
        }
    }
}