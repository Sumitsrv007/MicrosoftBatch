using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class TogalCase
    {
        static void Main(string[] args)
        {
            //this program for Lower to Uper case

            Console.WriteLine("Enter String:");
            String str = Console.ReadLine();
            String newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch > 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 32);
                }
                else
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
        }
    }
}
