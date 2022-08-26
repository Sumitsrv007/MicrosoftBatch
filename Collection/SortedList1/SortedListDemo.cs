using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.SortedList1
{
    class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<int, string> srt = new SortedList<int, string>();
            srt.Add(108, "Jack");
            srt.Add(103, "Jhon");
            srt.Add(207, "zain");
            srt.Add(106, "Calis");
            srt.Add(102, "Rohan");

            //srt.Remove(106);//Remove via key
            //srt.RemoveAt(2);//2 is index no
            //Console.WriteLine("Key Exist or Not :"+srt.ContainsKey(106));//ContainsKey return Bool value True or False
            //Console.WriteLine("Value Exist or Not :"+srt.ContainsValue("Jack"));//ContainsKey return Bool value True or False
           
           /* string val;
           if( srt.TryGetValue(102, out val))
            {
                Console.WriteLine("Value:"+val);
            } 
           else
            {
                Console.WriteLine("Value Not Found");
            }*/

           foreach (KeyValuePair<int,string> item in srt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------");
            /*SortedList<string,int> srt1 = new SortedList<string,int>();
            srt1.Add("Jack", 108);
            srt1.Add("Jhon",103);
            srt1.Add("zain", 207);
            srt1.Add("Calis", 106);
            srt1.Add("Rohan", 102);
            foreach (KeyValuePair<string, int> item in srt1)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
