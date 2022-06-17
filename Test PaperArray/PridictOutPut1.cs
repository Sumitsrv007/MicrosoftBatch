using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_PaperArray
{
    class PridictOutPut1
    {
        static int counter = 100;
        public static int carthy(int n)
        {
            counter++;
            if (n > 100)
            {
                return n - 10;
            }
            else
            {
                return carthy(n + 11);
            }
        }
        static void Main(string[] args)
        {
                Console.WriteLine(carthy(100)+" "+counter);
        }
    }
}
