using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Abstraction
{
    interface IGamable
    {
        void game();
    }
    abstract class PubG:IGamable
      {
        public abstract void Fill();
        public void game()
        {
            Console.WriteLine("Gamable Method if Interface");
        }
      }
    class Games : PubG
    {
        public override void Fill()
        {
            Console.WriteLine("Fill Method of abstract class");
        }
    }
    class InterfaceDemo4
    {
        static void Main(string[] args)
        {
            //1st way to create object
            Games g = new Games();
            g.Fill();
            g.game();
            //2nd way to create object
            PubG p = new Games();
            p.Fill();
            p.game();
        }
    }
}
