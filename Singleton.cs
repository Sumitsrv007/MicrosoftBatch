using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch
{
    sealed class Singleton
    {
        public static Singleton instance = null;
        private Singleton()
        {

        }
        public static Singleton MyObject()
        {
            if(instance==null)
            {
                return new Singleton();
            }
            return instance;
        }
    }
    class SingletonPattern
      {
       static void Main(string[] args)
         {
            Singleton s = Singleton.MyObject();
         }
      }
}
