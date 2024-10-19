using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ObjectTest
{
    internal class Fattura
    {
        private static int cntFattura = 0;
        private int nFattura;
        public Fattura()
        {
            cntFattura++;
            nFattura = cntFattura;
        }

        public int NFattura { 
            get => nFattura; }
    }
}
