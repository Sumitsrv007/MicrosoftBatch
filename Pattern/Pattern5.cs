using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Pattern
{
    class Pattern5
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 4; i++)
            {
                for (j = i; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
