using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paperString
{
    class UniqueElement
    {
        static void Main(string[] args)
        {
            int[] arr = {2,3,5,3,7,5 };
            int n = arr.Length;
            Console.WriteLine("Unique Elements:");
            for(int i=0;i<n;i++)
            {
                bool isDuplicate = false;
                for(int j=0;j<i;j++)
                {
                    if(arr[i]==arr[j])

                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if(!isDuplicate)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
}
