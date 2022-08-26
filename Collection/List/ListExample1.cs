using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.List
{
    class ListExample1
    {
        static void Main(string[] args)
        {
            //List is Strongly type & Homogeneous
            //List has Auto Resizing Concept
            //initial capacity is 4,auto increase by double means(4,8,18,32,64)
            List<int> lst = new List<int>();
            lst.Add(40);
            lst.Add(10);
            lst.Add(30);
            lst.Add(20);
            lst.Add(30);
            lst.Add(30);
            Console.WriteLine("Capacity-"+lst.Capacity);
            Console.WriteLine("Count-"+lst.Count);
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }

            lst.Sort();
            //lst.AddRange(lst);
            //lst.Insert(1, 111);//1 is index no,111 is no which i want to insert
            //lst.InsertRange(2,lst);//2 is index no,total elements of list add at the position of index 2
            //lst.Remove(20);//20 is element of list,remove directly,always remove 1st occurence of list
            //lst.RemoveAt(2);//2 is index no of lst
            //lst.RemoveRange(1,3);//Remove a range of the element,1 is index no,3 is total no which i want to remove
            //Console.WriteLine(lst.Contains(30));//Contains always return boolean value(true or false)
            //lst.Reverse();//Reverse all element of the list
            //Console.WriteLine(lst.IndexOf(30));//always return index no of the list
            //Console.WriteLine(lst.LastIndexOf(30));//return last index
            //lst.Clear();//remove all the elements
            Console.WriteLine("---------------------------");
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }
            /*List<string> lst1 = new List<string>();
            lst1.Add("Amit");
            lst1.Add("Riya");
            lst1.Add("Rohan");
            lst1.Add(null);
            lst1.Add("Riya");
            foreach (String item in lst1)
            {
                Console.WriteLine(item);
            }*/

        }

    }
}
