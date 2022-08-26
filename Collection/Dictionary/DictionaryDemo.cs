using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Dictionary
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(109, "Ronny");
            dict.Add(117, "Jhon");
            dict.Add(129, "Harry");
            dict.Add(1101, "Sam");
            dict.Add(20089, "Jhony");

            //1.print Dictionary
            //Console.WriteLine(dict[1101]);

            string value;
            if (dict.TryGetValue(1101, out value))
            {
                Console.WriteLine("Value Found-"+value);
            }
            else
            {
                Console.WriteLine("Value Not Found");
            }

           /* string value;
            dict.TryGetValue(1101, out value);
            Console.WriteLine(value);*/

            //Console.WriteLine(dict.ContainsKey(20089));//Return Bool value,true or false
            //Console.WriteLine(dict.ContainsValue("Sam"));//Return Bool value,true or false
            //2.print
            foreach (KeyValuePair<int,string> item in dict)
            {
                Console.WriteLine("Key "+item.Key+" Value "+item.Value);
            }
            //dict.Remove(117);//Remove one elements
            dict.Clear();//Clear all the elements
            Console.WriteLine("----------------------------");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key " + item.Key + " Value " + item.Value);
            }
            //3.Print Key
            /* foreach (int key in dict.Keys)
             {
                 Console.WriteLine(key);
             }*/

            //4.Print Value
            /*foreach (string value in dict.Values)
            {
                Console.WriteLine(value);
            }*/
        }
    }
}
