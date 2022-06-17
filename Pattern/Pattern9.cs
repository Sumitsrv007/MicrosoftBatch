using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Pattern
{
    class Pattern9
    {
        static void Main(string[] args)
        {
            int i, j,k,l,m;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 5; j++)
                {
                    Console.Write("* ");

                }
                for(m=i;m<=5;m++)
                {

                }
                Console.WriteLine(" ");
            }
            for (i = 2; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");

                }

                Console.WriteLine(" ");
            }
        }
    }
}
