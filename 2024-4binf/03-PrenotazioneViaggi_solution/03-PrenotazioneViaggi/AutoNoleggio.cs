using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrenotazioneViaggi
{
    internal class AutoNoleggio : Viaggio
    {
        private int giorniNoleggio;
        public int GiorniNoleggio { get => giorniNoleggio; set => giorniNoleggio = value; }

        public new decimal CalcolaCostoTotale()
        {
            // 20 di sconto se si noleggia un auto
            return Prezzo * giorniNoleggio - 20;
        }
    }
}
