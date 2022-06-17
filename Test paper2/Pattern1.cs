using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper2
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            int i, j,k;
            for(i=1;i<=4;i++)
            {
                for(j=i;j<=4;j++)
                {
                    Console.Write(" ");
                }
                for(k=1;k<=i;k++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
