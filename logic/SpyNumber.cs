using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.logic
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            int n, sum = 0, pow = 1, rem;
            Console.WriteLine("Enter Number:");
            n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                rem = n % 10;
                sum = sum + rem;
                pow = pow * rem;
                n = n / 10;
            }
            if(sum==pow)
            {
                Console.WriteLine(sum+" Number is Spy");
            }
            else
            {
                Console.WriteLine("Number is not spy");
            }
        }
    }
}
