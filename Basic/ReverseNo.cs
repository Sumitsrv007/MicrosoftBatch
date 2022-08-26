using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class ReverseNo
    {
        static void Main(string[] args)
        {
            int n, rem, reverse = 0;
            Console.WriteLine("Enter Number");
            n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
