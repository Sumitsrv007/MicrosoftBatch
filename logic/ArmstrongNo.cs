using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.logic
{
    class ArmstrongNo
    {
        static void Main(string[] args)
        {
            int num, rem, temp, sum = 0;
            Console.WriteLine("Enter Number:");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine(temp+" is ArmstrongNo no");
            }
            else
            {
                Console.WriteLine(temp+" is not Armstrong No");
            }
        }
    }
}
