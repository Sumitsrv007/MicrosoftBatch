using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Pattern
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
