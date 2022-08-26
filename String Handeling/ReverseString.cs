using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            /*String str = "India is my Country";
            char[] ch = str.ToCharArray();
            int j = ch.Length - 1;
            for(int i=0;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            //Console.WriteLine(String.Join(" ",ch));
            String st = new string(ch);
            Console.WriteLine(st);*/

            String str = " India is my Country ";
            String reverse = "";
            for (int i = str.Length-1; i >0; i--)
            {
                reverse = reverse+str[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
