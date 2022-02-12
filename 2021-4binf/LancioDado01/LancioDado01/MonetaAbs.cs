using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancioDado01
{
    class MonetaAbs : OggettoLanciato
    {
        Random rnd = new Random();

        public MonetaAbs()
        {
            x = 0; // testa
        }

        public override void Lancia()
        {
            x = rnd.Next(2);   // 0 testa; 1 croce
        }
    }
}
