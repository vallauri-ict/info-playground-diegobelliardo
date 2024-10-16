using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ObjectTest
{
    internal class Quadrato
    {
        private int lato;
        private Quadrato() { }
        private Quadrato(int lato) { 
            this.lato = lato;
        }

        public int Lato { get => lato; }

        public static Quadrato Create(int lato) { 
            if (lato >= 0) return new Quadrato(lato); 
            else return null;
        }
    }
}
