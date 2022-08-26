using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class ConNumber
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 3, 7, 10, 25, 120 };
            int max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max = a[5]-a[4];
                }
            }
            Console.WriteLine(max);
        }
    }
}
