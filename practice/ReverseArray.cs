using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class ReverseArray
    {
        static void Main(string[] args)
        {

            char[] ch = { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(string.Join(" ", ch));
            Console.WriteLine("---------------------");
            int j = ch.Length - 1;
            for (int i = 0; i < ch.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",ch));
        }
    }
}
