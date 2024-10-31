using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrenotazioneViaggi
{
    internal class Volo:Viaggio
    {
        private string compagniaAerea;
        public string CompagniaAerea { get => compagniaAerea; set => compagniaAerea = value; }

        public new decimal CalcolaCostoTotale()
        {
            return Prezzo + 100;
        }

    }
}
