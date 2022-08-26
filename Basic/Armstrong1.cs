using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class Armstrong1
    {
            static void Main(string[] args)
            {
                int n, rem, sum = 0, temp;
                Console.WriteLine("Enter Number");
                n = int.Parse(Console.ReadLine());
                temp = n;
                while (n > 0)
                {
                    rem = n % 10;
                    sum = sum + rem * rem * rem;
                    n = n / 10;
                }
                if (sum == temp)
                {
                    Console.WriteLine("Armstrong Number");
                }
                else
                {
                    Console.WriteLine("Not Armstrong Number");
                }
            }
        
    }
}
