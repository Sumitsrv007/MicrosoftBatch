using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class Prime_NoArray
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] a = { 4, 5, 6, 3, 8, 9, 7 };
            for(int i=0;i<a.Length;i++)
            {
                int n = a[i];
                bool prime = true;
                for(int j=2;j<n;j++)
                {
                    if(n%j==0)
                    {
                        prime = false;
                        break;
                    }
                }
               
                if(prime==true)
                {
                    Console.WriteLine(a[i]);
                    //Addition of Prime Number

                    sum = sum + a[i];
                    
                }
                Console.WriteLine("Prime Addition is=" + sum);
            }
          
        }
    }
}
