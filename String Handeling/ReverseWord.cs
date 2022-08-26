using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class ReverseWord
    {
        static void Main(string[] args)
        {
            String str = "C# is Easy";
            String[] str1 = str.Split(" ");
            String reverse = " ";
            for(int i=0;i<str1.Length;i++)
            {
                String word = str1[i];
                String myword = "";
                for(int j=word.Length-1;j>0;j--)
                {
                    myword = myword + word[j];
                }
                reverse = reverse + myword + " ";
            }
            Console.WriteLine(reverse);
        }
    }
}
