using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection
{
    class ListCollection1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(1000);
            li.Add(200);
            li.Add(300);
            li.Add(4000);
            li.Add(200);
            ;
            li[0] = 1122;
            Console.WriteLine(li.Count);
            Console.WriteLine(li.Capacity);
            for (int i = 0; i <li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }

            /* foreach(int data in li)
             {
                 Console.WriteLine(data);
             }*/
            Console.WriteLine((li.Contains(90)));
            Console.WriteLine("indexOf" + li.IndexOf(309));
            List<int> li1 = new List<int>() { 111, 112, 113 };
            //li1.AddRange(li)
            li1.InsertRange(1, li);
            for (int i = 0; i < li1.Count; i++)
            {
                Console.WriteLine(li1[i]);
            }
        }
    }
}
