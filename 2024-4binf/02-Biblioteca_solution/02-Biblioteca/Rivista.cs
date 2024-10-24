using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Biblioteca
{
    internal class Rivista : ElementoBiblioteca
    {
        private int numeroEdizione;
        public int NumeroEdizione { get => numeroEdizione; set => numeroEdizione = value; }

        public new int CalcolaPrestito() // Nasconde il CalcolaPrestito del padre
        {
            return 10;
        }
    }
}
