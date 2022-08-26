using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class VowelString
    {
        static void Main(string[] args)
        {
            string str = "abhishek";
            char ch;
            for (int i = 0; i < str.Length; i++)
            {
                ch = str[i];
                if(ch=='a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    
                    Console.WriteLine("Vovel Count="+ch);
                }
                else
                {
                    Console.WriteLine("Consonant Count=" + ch);
                }
            }
        }
    }
}
