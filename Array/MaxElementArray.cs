using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class MaxElementArray
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 4, 8, 3, 96, 9 };
            int max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Max Number " + max);
        }

    }
}
