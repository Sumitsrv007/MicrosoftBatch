using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_PaperArray
{
    class PredictOutput2
    {
        static void Main(string[] args)
        {
            
            int[] a1 = { 1, 2, 3 };
            int[] a2 = new int[a1.Length];
            for(int i=0;i<a1.Length;i++)
            {
                a2[i] = a1[i];
            }
            Console.WriteLine(String.Join(" ",a2));
        }
    }
}
