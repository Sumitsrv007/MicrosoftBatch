using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper2
{
    class Fabnnaci
    {
        static void Main(string[] args)
        {
            int a=1, b=1, c, i,n ;
            Console.WriteLine("Enter Number:");
            n = int.Parse(Console.ReadLine());
            for(i=0;i<=n;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(a);
            }
        }
    }
}
