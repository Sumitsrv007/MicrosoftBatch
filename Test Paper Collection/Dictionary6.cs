using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_Paper_Collection
{
    class Dictionary6
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> d = new Dictionary<string, float>();
            d.Add("Black", 22.098f);
            d.Add("Red", 47.26f);
            d.Add("Blue", 98.23f);
            foreach (KeyValuePair<string,float> item in d)
            {
                Console.WriteLine(item.Key+":"+item.Value);
            }
        }
    }
}
