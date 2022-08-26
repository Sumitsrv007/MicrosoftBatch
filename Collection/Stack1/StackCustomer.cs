using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Stack1
{
    class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Gender { get; set; }
    }
    class StackCustomer
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {  Id = 101,Name = "Zain",Gender = "Male" };
            Customer c2 = new Customer()
            { Id = 219, Name = "Riya", Gender = "Female" };
            Customer c3 = new Customer()
            { Id = 318, Name = "Amit", Gender = "Male" };
            Customer c4 = new Customer()
            { Id = 114, Name = "Priya", Gender = "Female" };

            Stack<Customer> st = new Stack<Customer>();
            st.Push(c1);
            st.Push(c2);
            st.Push(c3);
            st.Push(c4);

            Customer cst1 = st.Pop();
            Console.WriteLine("Pop = "+cst1.Id+" "+cst1.Name+" "+cst1.Gender);//Pop() remove and return the item at the top of stack

            Customer cst2 = st.Peek();
            Console.WriteLine("Peek= " + cst1.Id + " " + cst1.Name + " " + cst1.Gender);//Return top item from the stack

            Console.WriteLine(st.Contains(c1));//Contains Return Bool Value

            Console.WriteLine("Total Count="+st.Count);
            foreach (Customer item in st)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Gender);
            }
        }
    }
}
