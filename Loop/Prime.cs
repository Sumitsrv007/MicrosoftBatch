using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
                if (isPrime == true)
                {
                    Console.WriteLine(num + " prime No.");
                }
                else
                {
                    Console.WriteLine(num + " Not Prime No.");
                }
            
        }
    }



    class Prime2
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            for(int i=2;i<num;i++)
            {
                if (num % i == 0) ;
                {
                    count++;
                }
            }
            if(count==0)
            {
                Console.WriteLine("Prime no.");
            }
            else
            {
                Console.WriteLine("Not prime no.");
            }
        }
    }
}
