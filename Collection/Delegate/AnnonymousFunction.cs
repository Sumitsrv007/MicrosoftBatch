using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Delegate
{
    public delegate void MyDelegate(int a);
    class AnnonymousFunction
    {
        static void Main(string[] args)
        {
            MyDelegate m = delegate (int a)
              {
                  a += 10;
                  Console.WriteLine(a);
              };
            m(5);
        }
    }
}
