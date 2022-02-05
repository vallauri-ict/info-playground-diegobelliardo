using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract01
{
    class Cilindro : Figura
    {
        private int raggio;

        public Cilindro()
        {
        }

        public Cilindro(int raggio,int altezza)
        {
            this.raggio = raggio;
            base.altezza = altezza;
        }

        protected override double Area()
        {
            return raggio * raggio * Math.PI;
        }
    }
}
