using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int a,i, p = 1;
            Console.WriteLine("Enter Number");
            a = int.Parse(Console.ReadLine());
            for(i=1;i<=a;i++)
            {
                p = p * i;
            }
            Console.WriteLine(a+" Factorial is :"+p);
        }
    }
}
