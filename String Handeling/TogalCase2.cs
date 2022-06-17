using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class TogalCase2
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
                if (Char.IsUpper(ch))
                {
                    ch = Char.ToLower(ch);
                    //ch = (char)(ch + 32);
                }
                else if(Char.IsLower(ch))
                {
                    ch = Char.ToLower(ch);
                    //ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
        }
    }
}
