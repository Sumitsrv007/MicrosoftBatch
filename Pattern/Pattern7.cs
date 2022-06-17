using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Pattern
{
    class Pattern7
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
