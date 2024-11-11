using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOPOverride
{
    internal class Mannaro:Mostro
    {
        public override void Verso()
        {
            Console.WriteLine("Classe Mannaro: ululato");
        }
    }
}
