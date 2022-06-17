using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_PaperArray
{
    class PerfectSqure
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            int per = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                float d =(float) Math.Sqrt(arr[i]);
                //Console.WriteLine(d%1==0);
             if(d%1==0)
                {
                    Console.WriteLine(arr[i]);
                }

              /*  if(Math.Ceiling(d)==Math.Sqrt(arr[i]))
                {
                    Console.WriteLine(arr[i]);
                }*/

               
            }
          //  Console.WriteLine(String.Join(" ",per));
        }
    }
}
