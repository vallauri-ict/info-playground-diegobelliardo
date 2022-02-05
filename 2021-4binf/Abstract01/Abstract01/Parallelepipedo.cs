using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract01
{
    class Parallelepipedo : Figura
    {
        private int lato1, lato2;

        public Parallelepipedo()
        {
        }

        public Parallelepipedo(int lato1, int lato2, int altezza)
        {
            this.lato1 = lato1;
            this.lato2 = lato2;
            base.altezza = altezza;
        }

        protected override double Area()
        {
            return lato1 * lato2;
        }
    }
}
