using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class SumArrayElement
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] a = new int[4];
            Console.WriteLine("Enter Number");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
            }
            Console.WriteLine("Total Element Sum= "+sum);
        }
    }
}
