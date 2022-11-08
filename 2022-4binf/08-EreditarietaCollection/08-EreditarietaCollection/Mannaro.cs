using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EreditarietaCollection
{
    class Mannaro : Mostro
    {
        public bool mutato;
        protected new string verso;

        public Mannaro()
        {
            punti = 33;
            verso = "Ululato";
            mutato = true;
        }
        public new double Valore()
        {
            if (mutato)
            {
                return 2 * base.Valore();
            }
            else return base.Valore();
        }
        public new string Verso()
        {
            if (mutato)
            {
                return verso;
            }
            else return base.verso;
        }
        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
