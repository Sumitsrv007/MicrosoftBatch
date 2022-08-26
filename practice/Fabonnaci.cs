using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class Fabonnaci
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, i, sum;
            Console.WriteLine("Enter Number");
           int n = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (i = 2; i <= n; i++)
            {
                sum = a + b;
                Console.WriteLine(sum);
                a = b;
                b = sum;
                
            }
        }
    }
}
