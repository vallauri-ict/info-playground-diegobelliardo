using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_QuadratoFactoryEcc
{
    class Quadrato
    {
        private int lato;

        private Quadrato(int lato)
        {
            this.lato = lato;
        }

        public static Quadrato CreaQuadrato(int lato)
        {
            if (lato>0)
            {
                return new Quadrato(lato);
            }
            else
            {
                throw new Exception("Il lato deve essere maggiore di zero!");
            }
        }
    }
}
