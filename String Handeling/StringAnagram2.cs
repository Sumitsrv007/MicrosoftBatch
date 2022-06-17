using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class StringAnagram2
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

            if (ch1.Length == ch2.Length)
            {
                //sort Logic
                Console.WriteLine(String.Join(" ", ch1));
                Console.WriteLine(String.Join(" ", ch2));
                //Array.Sort(ch1);
                //Array.Sort(ch2);
                Console.WriteLine("-----------------------");
                Console.WriteLine(String.Join(" ", ch1));
                Console.WriteLine(String.Join(" ", ch2));
                String str1 = new string(ch1);
                String str2 = new string(ch2);
                bool flag = true;

                for (int i = 0; i < ch1.Length; i++)
                {
                    if (ch1[i] != ch2[i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
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
}
