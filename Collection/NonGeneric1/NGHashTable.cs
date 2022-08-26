using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace MicrosoftBatch.Collection.NonGeneric1
{
    class NGHashTable
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add("Id", 21049);
            h1.Add("Name", "Ronny");
            h1.Add("Salary", 30000.00);
            h1.Add("Designation", "Manager");
            h1.Add("Married", false);
            /*{ 
                { "Id",10220},
                { "Name","Ziya"},
                { "Age",27}
            };*/

            //Console.WriteLine(h1["Name"]);//Get Value from the key
            //Access Key and Value Both
            foreach (object item in h1.Keys)
            {
                Console.WriteLine(item+":"+h1[item]);
            }
            //Console.WriteLine("Ronny".GetHashCode());
            //h1.Remove("Married");
            //Console.WriteLine(h1.Contains("Name"));
            //Console.WriteLine(h1.ContainsKey("Age"));
            //Console.WriteLine(h1.ContainsValue("Ronny"));
            Console.WriteLine("--------------------");
            //Access Key
            foreach (object item in h1.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            //Access Value
            foreach(object item in h1.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
