using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Es9Pag115
{
    internal class Program
    {
        static string[] nomi = {
            "Marco", "Luca", "Andrea", "Giuseppe", "Paolo",
            "Antonio", "Francesco", "Stefano", "Matteo", "Davide"
        };

        static string[] citta = {
            "Alba", "Alba", "Bra", "Cuneo", "Cuneo",
            "Cuneo", "Dogliani", "Fossano", "Saluzzo", "Savigliano"
        };

        static void Main(string[] args)
        {
            bool trovato = false, superato=false;
            int i = 0, cont = 0;

            Console.Write("Inserisci il nome della città da cercare: ");
            string nomeCitta = Console.ReadLine();

            while (!superato && i<citta.Length)
            {
                if (citta[i] == nomeCitta)
                {
                    trovato = true;
                    cont++;
                    i++;
                }
                else
                {
                    if (citta[i].CompareTo(nomeCitta) > 0)
                    {
                        superato = true;
                    }
                    else i++;
                }
            }

            Console.WriteLine($"Il numero di studenti residenti a {nomeCitta} sono: {cont}");
        }
    }
}
