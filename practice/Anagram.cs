using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st String");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd String");
            string s2 = Console.ReadLine();
            char[] ch1 =s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
           // Array.Sort(ch1);
           // Array.Sort(ch2);
            String str1 = new string(ch1);
            String str2 = new string(ch2);

            if (str1==str2)
            {
                Console.WriteLine("String is Anagram");
            }
            else
            {
                Console.WriteLine("String is not Anagram");
            }
        }
    }
}
