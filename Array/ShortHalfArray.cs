using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class ShortHalfArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("Enter Number");
            for(int i=0;i<a.Length;i++)//This loop for Taking Array value from user
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for(int i=3;i<a.Length;i++)//This loop for index 0 to 5 Array
            {
                for(int j=i;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Shorting Half Array");
            Console.WriteLine(String.Join(" ",a));//String.Join(" ",arr)is use for print Array
        }
    }
}
