using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancioDado01
{
    class Moneta
    {
        private int v;
        Random rnd = new Random();

        public int V { get => v; set => v = value; }

        public Moneta()
        {
            this.V = 0;   // testa
        }

        public void lancio()
        {
            v = rnd.Next(2);   // 0 testa; 1 croce
        }
    }
}
