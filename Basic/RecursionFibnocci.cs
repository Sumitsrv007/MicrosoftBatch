using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class RecursionFibnocci
    {
        public static int Fib(int n)
        {
            if(n<=1)
            {
                return 1;
            }
            else
            {
                return (Fib(n - 1) + Fib(n - 2));
            }
           
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            n = n - 1;
            Console.WriteLine(Fib(n));
        }
    }
}
