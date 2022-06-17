using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class DeleteCharacter
    {
        static void Main(string[] args)
        {
            String str1 = "country";
            String str2 = "try";
            int newstr;
            for(int i=0;i<str1.Length;i++)
            {
                for (int j = 5; j < str2.Length; j++)
                {
                    newstr = str1[i] - str2[j];
                    Console.WriteLine(newstr);
                }
            }
        }
    }
}
