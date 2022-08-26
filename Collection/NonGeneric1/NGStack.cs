using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MicrosoftBatch.Collection.NonGeneric1
{
    class NGStack
    {
        static void Main(string[] args)
        {
            
            Stack st = new Stack();
            st.Push("Ronny");
            st.Push(29);
            st.Push(5.12);
            st.Push(false);
            st.Push(null);
            st.Push("Ronny");
            st.Push("Male");

            //st.Clear();
            //Console.WriteLine(st.Contains("Ronny"));
            //Console.WriteLine(st.Pop());//Pop Remove and Retrive data
            //Console.WriteLine(st.Peek());
            //Console.WriteLine(st.Count);
            foreach  (object item in st)
            {
                Console.WriteLine(item);
            }
        }
    }
}
