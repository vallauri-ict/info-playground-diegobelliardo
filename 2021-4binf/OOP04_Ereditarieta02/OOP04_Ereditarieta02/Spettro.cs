using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04_Ereditarieta02
{
    class Spettro:Mostro
    {
        private bool invisibile;

        public Spettro():base(30)
        {
            invisibile = true;
        }

        public Spettro(int p) : base(p)
        {
            invisibile = true;
        }
    }
}
