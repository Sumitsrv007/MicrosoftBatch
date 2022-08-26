using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class List1
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(101);
            l.Add(201);
            l.Add(101);
            l.Add(201);
            //l.Remove(201);
            l.RemoveAt(2);
            foreach (int item in l)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
