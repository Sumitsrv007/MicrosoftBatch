using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Exception_Handling
{
    class NotValidAge:Exception
    {
        public NotValidAge(string s):base(s)//base is use for Exception class
        {

        }
    }
    class CustomException
    {
        static void Age(int a)
        {
            if(a<18)
            {
                throw new NotValidAge("Age is Not Valid");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Age(15);
            }
            catch(NotValidAge na)
            {
                Console.WriteLine(na);
            }
        }
    }
//-------------Another Example of Custom Exception---------------
    class InvalidUser:Exception
    {
        public InvalidUser(string s):base(s)
        {

        }
    }
   class UserDefine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            int a = int.Parse(Console.ReadLine());

            try
            {
                if(a<18)
                {
                    throw new InvalidUser("You are not Eligible for vote");
                }
                else
                    Console.WriteLine("You are Eligible for vote");
            }
            catch(InvalidUser i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
