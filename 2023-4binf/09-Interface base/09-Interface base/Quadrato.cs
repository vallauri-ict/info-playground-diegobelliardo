using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interface_base
{
    internal class Quadrato : ICalcoliPoligoni
    {
        int lato;
        public float Area(int lato, int altezza)
        {
            return lato*altezza;
        }

        public int Perimetro()
        {
            return lato*4;
        }

        public Quadrato(int lato)
        {
            this.lato = lato;
        }
    }
}
