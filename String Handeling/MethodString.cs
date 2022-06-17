using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class MethodString
    {
        static void Main(string[] args)
        {
            String str = "Hello";
            String str1 = new string("Hello");

            Console.WriteLine(str==str1);
            Console.WriteLine(str.Equals(str1));//Equals Always use in String,not ==

            int i = str.CompareTo(str1);
            Console.WriteLine(i);
        }
    }
}
