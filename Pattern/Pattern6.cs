using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Pattern
{
    class Pattern6
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=5;i>=1;i--)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
