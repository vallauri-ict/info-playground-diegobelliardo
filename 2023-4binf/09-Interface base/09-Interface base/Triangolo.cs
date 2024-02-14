using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interface_base
{
    internal class Triangolo : ICalcoliPoligoni
    {
        int lato1, lato2, lato3, altezza;
        public float Area(int lato, int altezza)
        {
            return lato*altezza/2;
        }

        public int Perimetro()
        {
            return lato1+lato2+lato3;
        }

        public Triangolo(int lato1, int lato2, int lato3, int altezza)
        {
            this.lato1 = lato1;
            this.lato2 = lato2;
            this.lato3 = lato3;
            this.altezza = altezza;
        }
    }
}
