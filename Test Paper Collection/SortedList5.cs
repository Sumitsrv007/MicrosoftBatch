using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_Paper_Collection
{
    class SortedList5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> srt = new SortedList<int, string>();
            srt.Add(109,"Rohan");
            srt.Add(103,"Ziya");
            srt.Add(108,"Amit");
            foreach (KeyValuePair<int, string> item in srt)
            {
                Console.WriteLine(item.Key+":"+item.Value);
            }
        }
    }
}
