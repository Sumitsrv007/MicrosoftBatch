using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper2
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k <= 5; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
