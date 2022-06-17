using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Pattern
{
    class Table1_5
    {
        static void Main(string[] args)
        {
            int i, j,a,table=1;
            
            for(i=1;i<=5;i++)
            {
                for(j=1;j<=10;j++)
                {
                     table = j * i;
                    Console.Write(table);
                }
                Console.WriteLine("");
            }
        }
    }
}
