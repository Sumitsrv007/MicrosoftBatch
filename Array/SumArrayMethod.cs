using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class SumArrayMethod
    {
        int add = 0;
        int[] Sum(int[] a)
        {
            
            for (int i = 0; i < a.Length; i++)
            {
                 add = add + a[i];
            } 

            Console.WriteLine("Sum of Element" + add);
            return a;
        }
        static void Main(string[] args)
        {
            int[] arr = {1,0,2,5,3};

            SumArrayMethod s = new SumArrayMethod();
            int []b=  s.Sum(arr);
            Console.WriteLine(String.Join(" ",b));

        }
    }
}
