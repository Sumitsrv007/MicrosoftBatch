using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class ReversArray
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(String.Join(" ",ch));
            Console.WriteLine("---------------------");
            int j = ch.Length - 1;
            for(int i=0;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            //Print Array in Reverse Form
           /* for (int i = ch.Length; i > 0; i--)
            {
                Console.WriteLine(ch[i]+" ");
            }*/
            Console.WriteLine();
            Console.WriteLine(String.Join(" ",ch));
            /*for(int i=0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
            }*/

            
        }
    }
}
