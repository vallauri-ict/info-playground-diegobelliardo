using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrenotazioneViaggi
{
    internal class Hotel:Viaggio
    {
        private int numeroNotti;
        public int NumeroNotti { get => numeroNotti; set => numeroNotti = value; }

        public new decimal CalcolaCostoTotale()
        {
            return Prezzo * NumeroNotti;
        }
    }
}
