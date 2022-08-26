using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Queue
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue<String> sq = new Queue<string>();
            sq.Enqueue("India");
            sq.Enqueue("Russia");
            sq.Enqueue("America");
            sq.Enqueue("Japan");

            foreach (String item in sq)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Peek Element form Queue-" + sq.Peek());
            //Console.WriteLine("Remove Item form Queue-" + sq.Dequeue());
            //Console.WriteLine("Value Present or not-"+sq.Contains("Japan")); 
            //sq.Clear();
            Console.WriteLine("---------------------------");

            Queue<int> iq = new Queue<int>();
            iq.Enqueue(511);
            iq.Enqueue(829);
            iq.Enqueue(123);
            iq.Enqueue(9278);
            foreach (int item in iq)
            {
                Console.WriteLine(item);
            }
        }
    }
}
