using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Exception_Handling
{
    class ExceptionDemo
    {
        static void m1()
        {
            Console.WriteLine("M1 starts");
            Console.WriteLine("Enter Number");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("M1 Ends");
        }
         static void m2()
        {
            m1();
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Main Starts");
       try
        {
            m2();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Main Ends");
        }
        }
    }
}
