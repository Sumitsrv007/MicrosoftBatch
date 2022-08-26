using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class PrimeNum
    {
        static void Main(string[] args)
        {
            int i, j, n,psum=0;
            Console.WriteLine("Enter Number:");
            n = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                bool prime = true;
                for(j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine(i + " ");
                    psum = psum + i;
                }
            }
           Console.WriteLine("Total Prime Sum=" + psum);
        }
    }
}
