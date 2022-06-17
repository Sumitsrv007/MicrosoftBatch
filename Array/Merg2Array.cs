using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class Merg2Array
    {
        static void Main(string[] args)
        {
            int inx1=0, inx2 = 1;
            int[] a = {1,2,3,4};
            int[] b = { 0, 9, 8, 7 };
            int mearg = a.Length + b.Length;
            int []c = new int[mearg];
            Console.WriteLine("1St Array :"+String.Join(" ",a));
            Console.WriteLine("2nd Array :" + String.Join(" ", b));
            for(int i=0;i<a.Length;i++)
            {
                c[inx1] = a[i];
                inx1 = inx1 + 2;
            }

            for (int i = 0; i < b.Length; i++)
            {
                c[inx2] = b[i];
                inx2 = inx2 + 2;
            }
            Console.WriteLine("After Merging :"+String.Join(" ",c));
        }
    }
}
