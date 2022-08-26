using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MicrosoftBatch.Collection.NonGeneric1
{
    class SortedListNonGeneric
    {
        static void Main(string[] args)
        {
            SortedList srt = new SortedList();
            srt.Add(222,"Amit");
            srt.Add(192, "Riya");
            srt.Add(846, "Jay");
            srt.Add(916, "Ziya");

            srt.Remove(846);//846 is key
            srt.RemoveAt(2);//2 is index no.

            bool result1 = srt.Contains(1);
            bool result2 = srt.ContainsKey(192);
            bool result3 = srt.ContainsValue("Ziya");

            //1.print
            /*for(int i=0;i<srt.Count;i++)
            {
                Console.WriteLine("key :{0},Value :{1}",srt.GetKey(i),srt.GetByIndex(i));
            }*/

            //2.print
            foreach (DictionaryEntry item in srt)
            {
                Console.WriteLine("key :{0},Value :{1}", item.Key, item.Value);
            }
        }
    }
}
