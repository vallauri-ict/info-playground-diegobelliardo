using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EsInterfacceLibreria
{
    internal class Utente : IUtente
    {
        public string Name { get; set; }
        public int NTessera { get; set; }

        public Utente(string name, int nTessera)
        {
            Name = name;
            NTessera = nTessera;
        }

        public void PrendiInPrestitoItem(ILibreriaItem item)
        {
            item.PrendiInPrestito();
        }

        public void RestituisciItem(ILibreriaItem item)
        {
            item.Restituisci();
        }
    }
}
