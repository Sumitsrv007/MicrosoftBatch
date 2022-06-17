using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Pattern
{
    class Pattern8
    {
        static void Main(string[] args)
        {
            int i, j,a=1;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(a++);
                    
                }
                Console.WriteLine();
            }
        }
    }
}
