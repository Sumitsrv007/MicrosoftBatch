using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class ArrayPrinting
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Elemwnts");
                int b = int.Parse(Console.ReadLine());
                a[i] = b;
            }
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }

            //Console.WriteLine(String.Join(" ",a));

            /* for(int i=0;i<a.Length;i++)
             {
                 Console.WriteLine(a[i]);
             }*/
        }
    }
}
