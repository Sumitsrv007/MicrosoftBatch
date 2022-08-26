using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class MaxElementsInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 1, 8, 9, 5, 56 };
            int max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max Element is:"+max);
        }
    }
}
