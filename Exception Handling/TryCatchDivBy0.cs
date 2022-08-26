using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Exception_Handling
{
    class TryCatchDivBy0
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());

            try
            {
                int c = a / b;
                Console.WriteLine("Division is=" + c);
            }
            catch(Exception e)
            {
                Console.WriteLine("Enter a Valid number");
                //Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Executed");
            }
        }
    }
}
