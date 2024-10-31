using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrenotazioneViaggi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Viaggio viaggio = new Viaggio();
            Hotel hotel = new Hotel();
            Volo volo = new Volo();
            AutoNoleggio auto = new AutoNoleggio();

            viaggio.Prezzo = 1000;
            viaggio.Destinazione = "Palermo";
            viaggio.DataPartenza = DateTime.Today;

            hotel.NumeroNotti = 5;
            hotel.Destinazione = "Milano Marittima";
            hotel.DataPartenza= DateTime.Today;
            hotel.Prezzo= 2000;

            Console.WriteLine($"Costo Viaggio: {viaggio.CalcolaCostoTotale()}");
            Console.WriteLine($"Costo Hotel: {hotel.CalcolaCostoTotale()}");
            Console.ReadKey();

        }
    }
}
