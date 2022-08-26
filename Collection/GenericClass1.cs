using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection
{
    class Example<T>    //<T> T is a Placeholder,You can store any type of data type
    {
        T box;

        public T Box 
        { 
           set
            {
                this.box=value;
            }
            get
            {
                return box;
            }
        }
        /*public Example(T b)
        {
            this.box = b;
        }
        public T getBox()
        {
            return this.box;
        }*/
    }
    class GenericClass1
    {
        static void Main(string[] args)
        {
            Example<int> e = new Example<int>();
            e.Box = 200;
            Example<char> e1 = new Example<char>();
            e1.Box = 'Z';
            Example<String> e2 = new Example<String>();
            e2.Box = "Amit";
            Console.WriteLine(e.Box+" "+e1.Box+" "+e2.Box);
           /* Example<int> e = new Example<int>(20);
            Example<String> e1 = new Example<String>("Ronny");
            Example<float> e2 = new Example<float>(1.89f);
            Console.WriteLine(e.getBox());
            Console.WriteLine(e1.getBox());
            Console.WriteLine(e2.getBox());*/
            
        }
    }
}
