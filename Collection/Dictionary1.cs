using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection
{
    class Dictionary1
    {
        static void Main(string[] args)
        {
            //first create Emp,Emp not here that's why getting error
           /* List<Emp> l1 = new List<Emp>();
            l1.Add(new Emp("Deepa", 8));
            l1.Add(new Emp("Sapna", 9));*/
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Rocky", 50);
            dd.Add("Tom", 80);
            dd.Add("Jhon", 70);
            dd.Add("Sam", 60);
            //Duplicates not allowed in Dictionary
            Console.WriteLine(dd["Jhon"]);
            dd["Sam"] = 94;//for update
            dd.Remove("Tom");//remove pair(key,value)
            dd.ContainsKey("Jyoti");
            dd.ContainsValue(56);

           /* for(KeyValuePair kp in dd)
            {
                Console.WriteLine(kp.Key +"--"+);
            }*/
        }
    }
}
