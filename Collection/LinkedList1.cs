using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection
{
    class LinkedList1
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>();

            l1.AddLast(100);
            l1.AddLast(200);
            l1.AddLast(300);
            l1.AddLast(200);

            LinkedListNode<int> nn = l1.Find(200);
            l1.AddBefore(nn, 1000);

            l1.AddAfter(nn, 20000);
            Console.WriteLine(l1.Count);//use for all list count
            Console.WriteLine(l1.Contains(34));
           /* int d= l1.First();
            int last = l1.Last();
            l1.Remove(90);
            foreach (int x in l1)
            {
                Console.WriteLine(x);
            }*/
        }
    }
}
