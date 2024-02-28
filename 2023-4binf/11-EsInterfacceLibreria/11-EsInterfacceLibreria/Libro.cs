using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_EsInterfacceLibreria
{
    internal class Libro : ElementoLibreria
    {
        public int NumeroPagine { get; set; }

        public Libro(string titolo, string autore, int numeroPagine):base(titolo,autore)
        {
            NumeroPagine = numeroPagine;
        }

        public override void PrendiInPrestito()
        {
            this.Prestito = true;
            MessageBox.Show($"Il libro {Titolo} è stato preso in prestito");
        }

        public override void Restituisci()
        {
            this.Prestito = false;
            MessageBox.Show($"Il libro {Titolo} è stato restituito");
        }
    }
}
