using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EsInterfacciaLibri
{
    internal class Book : IBook
    {
        public string Titolo { get; }

        public string Autore { get; }

        public double Prezzo { get; }

        public Book(string titolo, string autore, double prezzo)
        {
            Titolo = titolo;
            Autore = autore;
            Prezzo = prezzo;
        }
    }
}
