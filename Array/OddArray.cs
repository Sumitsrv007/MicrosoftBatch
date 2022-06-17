using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class OddArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Number:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
