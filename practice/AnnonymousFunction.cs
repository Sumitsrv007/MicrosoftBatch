using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    public delegate void Mydelegate(string s);
    class AnnonymousFunction
    {
        static void Main(string[] args)
        {
            Mydelegate m = delegate (string s)
              {
                  //int l = s.Length;
                  Console.WriteLine(s);
              };
            m("Ronny");
        }
    }
}
