using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.logic
{
    class OddSqureEven
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter Number:");
            int no = int.Parse(Console.ReadLine());

            for(i=1;i<=no;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
