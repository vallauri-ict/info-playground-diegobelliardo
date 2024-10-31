using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrenotazioneViaggi
{
    internal class Viaggio
    {
        private string destinazione;
        private DateTime dataPartenza;
        private decimal prezzo;

        public string Destinazione { get => destinazione; set => destinazione = value; }
        public DateTime DataPartenza { get => dataPartenza; set => dataPartenza = value; }
        public decimal Prezzo { get => prezzo; set => prezzo = value; }

        public decimal CalcolaCostoTotale()
        {
            return Prezzo;
        }
    }
}
