using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.logic
{
    class Pallindrom
    {
        static void Main(string[] args)
        {
            int n, sum = 0, rem, temp;
            Console.WriteLine("Enter Number:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine(sum+" Number is Pallindrom");
            }
            else
            {
                Console.WriteLine(sum+ "Number is not Pallindrom");
            }
        }
    }
}
