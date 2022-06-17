using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper2
{
    class PredictBehave3
    {
        static void Main(string[] args)
        {
            for(int i=5;i>0;i--)
            {
                int m = 100;
                m = m - i;
                Console.WriteLine(m);
            }
        }
    }
}
