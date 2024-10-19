using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ObjectTest
{
    internal class Singleton
    {
        private Singleton() { }

        static Singleton()
        {
            instance = null;
        }
        // OPPURE:
        // private static Singleton instance=null;


        private static Singleton instance;
        private int val;

        public int Val { get => val; set => val = value; }

        public static Singleton getInstance() {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance; 
        }


    }
}
