using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class ArrayMethod
    {
        int [] DoSort(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] a = {8,4,9,3,2,7};
            ArrayMethod a1 = new ArrayMethod();
            int[]newArr=a1.DoSort(a);
            Console.WriteLine(String.Join(" ", newArr));
        }
    }
}
