using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop
{
    class FactorAdd
    {
        static void Main(string[] args)
        {
           // int sum = 0;
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                   // sum = sum + i;
                }
               // Console.WriteLine(sum);
            }
        }
    }
}
