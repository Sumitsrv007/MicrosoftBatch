using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper1
{
    class SwitchVowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alfabates:");
            char al = char.Parse(Console.ReadLine());
            switch(al)
            {
                case 'a':
                    Console.WriteLine(al+" is vowel");
                    break;
                case 'e':
                    Console.WriteLine(al + " is vowel");
                    break;

                case 'i':
                    Console.WriteLine(al + " is vowel");
                    break;
                case 'o':
                    Console.WriteLine(al + " is vowel");
                    break;
                case 'u':
                    Console.WriteLine(al + " is vowel");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}
