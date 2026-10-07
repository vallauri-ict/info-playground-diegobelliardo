using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contatore objA = Contatore.CreaContatore(-1);
            Contatore obj1 = new Contatore(-1);
        }
    }
}
