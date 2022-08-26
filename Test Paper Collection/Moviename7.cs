using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_Paper_Collection
{
    class Moviename7
    {
        static void Main(string[] args)
        {
            Stack<String> s = new Stack<String>();
            s.Push("Tenet");
            s.Push("Deadpool");
            s.Push("Avanger");
            s.Push("Inferno");

            s.Pop();
            foreach (string item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
