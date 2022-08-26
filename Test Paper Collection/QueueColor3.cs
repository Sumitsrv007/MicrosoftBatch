using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_Paper_Collection
{
    class QueueColor3
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Red");
            q.Enqueue("Blue");
            q.Enqueue("Green");
            q.Enqueue("Black");

            foreach (string item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
