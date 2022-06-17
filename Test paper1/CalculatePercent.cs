using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper1
{
    class CalculatePercent
    {
        static void Main(string[] args)
        {
            int Math = 93, Eng = 76, Phy = 85, Che = 67, Bio = 80;
            int total = Math + Eng + Phy + Che + Bio;
            int average = total / 5;
            float percentage = (total / 500) * 100;
            Console.WriteLine("TOtal Total of 5 Subject:" + total);
            Console.WriteLine("TOtal Average of 5 Subject:" + average);
            Console.WriteLine("TOtal % of 5 Subject:"+percentage);

        }
    }
}
