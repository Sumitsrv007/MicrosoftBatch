using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_PaperArray
{
    class RemoveDuplicates
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 4, 9, 2 };
            int n = arr[0];
            int x;
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;)
                {
                    if(arr[i]==arr[j])
                    {
                        for( x=j;x<arr.Length;x++)
                        {
                            arr[x] = arr[x + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
