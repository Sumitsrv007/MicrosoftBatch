using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.HashSet1
{
    class HashSetMethods
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>();
    
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            HashSet<string> myhash2 = new HashSet<string>();

            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            //myhash1.ExceptWith(myhash2);//This method is used to remove all elements in the specified collection from the current HashSet object.
            //myhash1.IntersectWith(myhash2);//This method is used to modify the current HashSet object to contain only elements that are present in that object and in the specified collection.
            //myhash1.UnionWith(myhash2);//This method is used to modify the current HashSet object to contain all elements that are present in itself, the specified collection, or both.
            foreach (string ele in myhash1)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
