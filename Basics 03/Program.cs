#region 13st answer
//Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot 
//divide by zero", and then prints "Done" in a finally block. 
#endregion
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int num1 = 10;
            int num2 = 0;
            int result = num1 / num2;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }
    }
}