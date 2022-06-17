using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class StringCreation
    {
        static void Main(string[] args)
        {
            String str = "Hello C#";//keyword
            String s = "Hello Donet";//literal
            String s1 = new string("Hello My Programing");//using new

            int l = s1.Length;
            Console.WriteLine("Length="+l);

            String str1 = "Hello";
            String str2 = "Hello";

            /*Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());
            Console.WriteLine(str1 == str2);str1 = str1 + "C#";
            Console.WriteLine(str1);
            Console.WriteLine(str1==str2);
            Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());*/

            String st = String.Concat(str1, "Pune");
            Console.WriteLine(st+" "+str1);

            int x = s1.IndexOf('r');
            Console.WriteLine(s1+" "+x);

            int y = s1.LastIndexOf('r');
            Console.WriteLine(s1+" "+y);

            String s3 = s1.Substring(4);

            Console.WriteLine(s3);
            String s4 = s1.Substring(4);
            Console.WriteLine(s4);
            String myString = "Java,C#,C++,Python";
            String[] s5 = myString.Split(",");//split method is use for break the STringin saprate saprate word

            foreach(String ss in s5)
            {
                Console.WriteLine(ss);
            }

            Console.WriteLine(String.Join(" ","pune"," ","Welcome" ));

            String s6 = "      Pune        ";
            Console.WriteLine(s6);
            Console.WriteLine(s6.Trim());

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            Console.WriteLine(s1[10]);
        }
    }
}
