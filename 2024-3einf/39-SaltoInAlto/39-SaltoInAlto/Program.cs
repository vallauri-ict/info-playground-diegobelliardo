using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_SaltoInAlto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] atleti = {"Ambrogio","Bodoaga","Borbone","Burdisso",
                "Cerone","Dzeljo","Ferrero","Fontana","Hoxha","Kardash" };
            string[] nazione = new string[atleti.Length];
            string[] sesso= new string[atleti.Length];
            int[] salti=new int[atleti.Length];

            ClsSalti.CaricaNazioni(nazione);
            ClsSalti.CaricaSesso(sesso);
            ClsSalti.CaricaSalti(salti);

            int scelta;
            do
            {
                scelta = visualizzaMenu();
                switch (scelta)
                {
                    case 1:
                        ClsSalti.VisualizzaDati(atleti, sesso, nazione, salti);
                        break;
                    case 2:
                        ClsSalti.ClassificaGenerale(atleti,sesso, nazione, salti);
                        ClsSalti.VisualizzaDati(atleti, sesso, nazione, salti);
                        break;
                    case 3:
                        Console.Write("Inserisci la nazione: ");
                        string naz=Console.ReadLine();
                        double media = ClsSalti.MediaSaltiNazione(atleti, sesso, nazione, salti, naz);
                        if (media == -1)
                        {
                            Console.WriteLine($"La nazione {naz} non è presente!");
                        }
                        else
                        {
                            Console.WriteLine($"La media della nazione {naz} è "+media.ToString("F2"));
                        }
                        break;
                    case 4:
                        ClsSalti.MediaSaltiOgniNazione(atleti, sesso, nazione, salti);
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 0:
                        Console.WriteLine(scelta);
                        break;
                }
                Console.ReadKey();

            }
            while (scelta != 0);
        }

        private static int visualizzaMenu()
        {
            int sc;

            Console.Clear();
            Console.WriteLine("---   SALTO IN ALTO   ---");
            Console.WriteLine("1: Visualizza Dati");
            Console.WriteLine("2: Classifica Generale");
            Console.WriteLine("3: Media Salti Nazione in Input");
            Console.WriteLine("4: Media Salti di ogni Nazione");
            Console.WriteLine("5: Classifica per Nazioni");
            Console.WriteLine("6: Media salti uomini e donne");
            Console.WriteLine("7: Cercare i vincitori M e F della nazione prima classificata");
            Console.WriteLine("0: Esci");
            while (!int.TryParse(Console.ReadLine(), out sc) && sc<=7 && sc>=0);

            return sc;
        }

    }
}
