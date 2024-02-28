using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EsInterfacceLibreria
{
    public abstract class ElementoLibreria : ILibreriaItem
    {
        public string Titolo{ get; set;}
        public string Autore { get; set; }
        public bool Prestito { get; set; }

        protected ElementoLibreria(string titolo, string autore)
        {
            Titolo = titolo;
            Autore = autore;
            Prestito = false;
        }

        public abstract void PrendiInPrestito();

        public abstract void Restituisci();
    }
}
