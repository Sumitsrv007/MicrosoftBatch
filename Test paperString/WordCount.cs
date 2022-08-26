using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paperString
{
    class WordCount
    {
        static void Main(string[] args)
        {
            String str = "Programming";
            int count = str.Length;
            Console.WriteLine("Total Words="+count);
        }
    }
}
