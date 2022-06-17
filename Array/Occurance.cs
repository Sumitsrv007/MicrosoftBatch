using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class Occurance
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 3, 5, 7, 9, 3, 5, 8, 2, 3 };
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isVisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[k]==a[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if(isVisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+count);
                }
            }
        }
    }
}
