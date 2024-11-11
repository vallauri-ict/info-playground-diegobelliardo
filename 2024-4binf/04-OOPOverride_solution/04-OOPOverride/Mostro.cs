using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOPOverride
{
    internal class Mostro
    {
        public virtual void Verso()
        {
            Console.WriteLine("Classe Mostro: grugnito");
        }
    }
}
