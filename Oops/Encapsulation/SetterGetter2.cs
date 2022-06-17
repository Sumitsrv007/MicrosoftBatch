using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Encapsulation
{  
    class Student
    {
        private int id;
        private String name;
        private int roll_no;

        public int Id { get => id; set => id = value; }
       public string Name { get => name; set => name = value; }
       public int Roll_no { get => roll_no; set => roll_no = value; }//property by Encapsulation reflactor-->edit-->Reflactor-->Encapsulation Reflector
      
        /* public int Id
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public int Roll_no
        {
            get;
            set;
        }*/
    }
    class SetterGetter2
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            s.Id = 19234;
            s.Name = "Sumit";
            s.Roll_no = 112233;

            Console.WriteLine(s.Id + " " + s.Name + " " + s.Roll_no);
        }
    }
}
