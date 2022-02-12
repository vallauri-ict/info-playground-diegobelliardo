using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancioDado01
{
    class DadoAbs : OggettoLanciato
    {
        Random rnd = new Random();
        public DadoAbs()
        {
            x = 1;
        }

        public override void Lancia()
        {
            x = rnd.Next(6) + 1;
        }
    }
}
