using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Biblioteca
{
    internal class ElementoBiblioteca
    {
        private string titolo;
        private string autore;
        private int annoPubblicazione;

        public string Titolo { get => titolo; set => titolo = value; }
        public string Autore { get => autore; set => autore = value; }
        public int AnnoPubblicazione { get => annoPubblicazione; set => annoPubblicazione = value; }

        public int CalcolaPrestito()
        {
            return 14;  // Periodo base di 14 giorni di prestito
        }
    }
}
