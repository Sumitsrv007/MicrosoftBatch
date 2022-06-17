using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter value:");
            a = int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine(a+" is Even Number");
            }
            else
            {
                Console.WriteLine(a + " is Odd Number");
            }
        }
    }
}
