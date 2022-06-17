using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_PaperArray
{
    class Pen
    {
        private int refil;
        private int capLength;
        private String brand;

        public int Refil
        {
           
            get { return refil; }
            set { refil = value; }
        }
        public int CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public String Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }
    class PenSetterGetter
    { 
        static void Main(string[] args)
        {
            Pen s =new Pen();
            s.Refil = 1;
            s.CapLength = 20;
            s.Brand = "Jupiter";
            Console.WriteLine(s.Refil+" "+s.CapLength+" "+s.Brand);
            
        }
    }
}
