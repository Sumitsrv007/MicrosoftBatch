using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_Paper_Collection
{
    class SortListQ1
    {
        static void Main(string[] args)
        {
            SortedList<String, int> srt = new SortedList<string, int>();
            srt.Add("Rohan", 109);
            srt.Add("Ziya", 103);
            srt.Add("Amit", 108);
            foreach (KeyValuePair<string,int> item in srt)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
