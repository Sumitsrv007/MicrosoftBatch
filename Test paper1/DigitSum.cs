using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper1
{
    class DigitSum
    {
        static void Main(string[] args)
        {
            int num, rem,i;
            Console.WriteLine("Enter Number:");
            num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
