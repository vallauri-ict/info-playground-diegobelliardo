using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafiDijkstra
{
    class Arco
    {
        public int Destinazione { get; set; }
        public int Peso { get; set; }

        public Arco(int destinazione, int peso)
        {
            Destinazione = destinazione;
            Peso = peso;
        }
    }
}
