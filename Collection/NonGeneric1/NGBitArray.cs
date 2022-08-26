using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace MicrosoftBatch.Collection.NonGeneric1
{
    class NGBitArray
    {
        static void Main(string[] args)
        {
            BitArray myBitArr = new BitArray(5);

            myBitArr[0] = true;
            myBitArr[1] = true;
            myBitArr[2] = false;
            myBitArr[3] = true;
            myBitArr[4] = false;

            //Console.WriteLine(myBitArr.IsReadOnly);//Return false
            //Console.WriteLine(myBitArr.Count);//return 5
            foreach (object item in myBitArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
