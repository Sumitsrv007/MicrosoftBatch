using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop
{
    class SeriesOddSqure
    {
        static void Main(string[] args)
        {
            int i;
                for(i=1;i<=10;i++)
                {
                  if(i%2==0)
                  {
                    Console.WriteLine(i);
                  }
                else
                {
                    Console.WriteLine(i*i);
                }
                }
        }
    }
}
