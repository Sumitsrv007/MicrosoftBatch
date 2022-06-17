using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class StringAnagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st String");
            string s = Console.ReadLine();
            Console.WriteLine("Enter 2nd String");
            string s1 = Console.ReadLine();

            string st1 = s.ToLower();
            string st2 = s.ToLower();

            char[] ch1 = st1.ToCharArray();
            char[] ch2 = st2.ToCharArray();

            //sort Logic
            Console.WriteLine(String.Join(" ",ch1));
            Console.WriteLine(String.Join(" ",ch2));
            //Array.Sort(ch1);
           // Array.Sort(ch2);
            Console.WriteLine("-----------------------");
            Console.WriteLine(String.Join(" ", ch1));
            Console.WriteLine(String.Join(" ", ch2));
            String str1 = new string(ch1);
            String str2 = new string(ch2);

            if(str1.Equals(str2))
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
