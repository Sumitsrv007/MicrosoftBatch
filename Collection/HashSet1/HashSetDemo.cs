using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.HashSet1
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>();

            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

            //myhash1.Remove("Ruby");
            //Console.WriteLine("Total number of elements present (After Removal)" + myhash1.Count);
            //myhash1.Clear();

            foreach (String val in myhash1)
            {
                Console.WriteLine(val);
            }

            
            HashSet<int> myhash2 = new HashSet<int>() {10,
                               100,1000,10000,100000};

            Console.WriteLine("Elements of myhash2:");
            foreach (int value in myhash2)
            {
                Console.WriteLine(value);
            }

        }
    }
}
