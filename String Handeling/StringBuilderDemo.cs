using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class StringBuilderDemo
    {
        static void Main(string[] args)
        {
            String s = "pune";
            StringBuilder sb = new StringBuilder(s);
            Console.WriteLine(sb);
            sb.Append("City");//use for add string to present string
            sb.AppendLine(" for Fun");
            Console.WriteLine(sb);

            sb.Insert(6, "c#");//6 is index possition and place c#
            Console.WriteLine(sb);

            sb.Remove(2, 6);//2 is index and 6 is a possition of string
            Console.WriteLine(sb);

            for(int i=0;i<sb.Length;i++)
            {
                Console.WriteLine(sb[i]);
            }

            //String str=sb.ToString();//ToString is use for covert into String

        }
    }
}
