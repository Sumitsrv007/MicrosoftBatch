using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class Dictionary1
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("fdsjh", 101);
            d.Add("qqqqq", 202);
            d.Add("kkkkk", 383);
            // d.Add("qqqqq", 202);
            foreach (KeyValuePair<string,int> item in d)
            {
                Console.WriteLine("key="+item.Key);
            }
        }
    }
}
