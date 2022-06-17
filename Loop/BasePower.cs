using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop
{
    class BasePower
    {
        static void Main(string[] args)
        {
            int result=1;
            Console.WriteLine("Enter Base:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Base:");
            int p = int.Parse(Console.ReadLine());
            for(int i=1;i<=p;i++)
            {
                result = result * b;
                
            }
            Console.WriteLine(result);

        }
    }
}
