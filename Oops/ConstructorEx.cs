using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops
{
    class Enformation
    {
        int id;
        String name;
        int marks;

        //this keyword use with variable & method
        public void data(int id, String name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;

            this.show();

        }

        public void show()
        {
            Console.WriteLine(id+" "+name+" "+marks);
        }

        //this keyword use with constructor
        long number;
        String namee;
        public Enformation():this(767886009,"Jhon")
        {
            Console.WriteLine("This is default Constructor");
        }

        
        public Enformation(int number,String namee)
        {
            this.number = number;
            this.namee = namee;
            Console.WriteLine(number+" "+namee);
        }

       
    }
    class ConstructorEx
    {


        static void Main(string[] args)
        {
            Enformation e = new Enformation();
            e.data(101, "Rohan", 98);

        }
    }
}
