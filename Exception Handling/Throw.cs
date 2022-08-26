using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Exception_Handling
{
    class Throw
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
          try 
          {
            if(age>18)
            {
                Console.WriteLine("You are Eligible for Vote");
            }
            else
            {
                throw new Exception("You are Not Eligible");
            }
          }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("I am Finally Block");
            }
        }
    }
}
