using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class MaxElementFromUser
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int max = a[0];
            Console.WriteLine("Enter No 1 to 5");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int j=0;j<a.Length;j++)
            {
                if(a[j]<max)
                {
                    max = a[j];
                }
            }
            Console.WriteLine(max + "Max no");
        }
    }
}
