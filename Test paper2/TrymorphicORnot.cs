using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper2
{
    class TrymorphicORnot
    {
        static void Main(string[] args)
        {
            int n, squre,rem;
            Console.WriteLine("Enter Number:");
            n = int.Parse(Console.ReadLine());
            squre = n * n;
            rem = squre % 10;
            while(n>0)
            {
                if (n == rem)
                {
                    Console.WriteLine(n + " is Automorphic no");
                }
                else
                    Console.WriteLine("Wrong input");
            }
            

        }
    }
}
