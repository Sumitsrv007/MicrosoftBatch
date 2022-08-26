using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace MicrosoftBatch.Collection.NonGeneric1
{
    class NGArrayList1
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("Jack");
            a1.Add(26);
            a1.Add(5.23);
            a1.Add(null);
            a1.Add("jack");
            a1.Add(false);
            a1.Add("z");

            //a1.Insert(2, "Rehan");//2 is index and Rehan is value
            //a1.Remove(null);//null is value object
            //a1.RemoveAt(2);
            foreach (object item in a1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
