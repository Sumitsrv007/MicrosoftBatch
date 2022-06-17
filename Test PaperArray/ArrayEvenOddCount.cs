using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_PaperArray
{
    class ArrayEvenOddCount
    {
        static void Main(string[] args)
        {
            // int even = 0,odd=0;
            
            int[] a = { 4,1,7,6,3,14};
            Console.WriteLine("Array length "+a.Length);
            Console.WriteLine("------------------------");
            int countEven=0, countOdd = 0;
            for (int i=0;i<a.Length;i++)
            {

                if (a[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            Console.WriteLine("Total Even Element: "+countEven);
            Console.WriteLine("Total Even Element: " + countOdd);
        }
    }
}
