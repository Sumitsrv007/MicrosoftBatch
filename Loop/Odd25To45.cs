using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop
{
    class Odd25To45
    {
        static void Main(string[] args)
        {
            int i;
            for(i=25;i<=45;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
