﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_PaperArray
{
    class MinimumChar
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'b', 'c', 'c', 'b' };
            char min = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
                
            }
            Console.WriteLine("Minimum Array Element:" + min);
        }
    }
}
