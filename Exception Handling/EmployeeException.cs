using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Exception_Handling
{
    class InvalidExperinceException:ApplicationException
    {

    }
    class Emp
    {
        string nm;
        int experience;
        public string Nm
        {
            set { this.nm=value; }
            get { return nm; }
        }
        public override string ToString()
        {
            return "Name:"+nm+" Experience:"+experience;
        }
        public int Experience
        {
            set
            {
                if (value < 0)
                    throw new InvalidExperinceException(); 
                else
                    this.experience = value;
            }
            get { return experience; }
        }
    }
    class EmployeeException
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            Console.WriteLine("Enter name and Experience");
            e1.Nm = Console.ReadLine();
            try
            {
                e1.Experience=int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Experience can't be Nagative");
            }
            Console.WriteLine(e1);
        }
    }
}
