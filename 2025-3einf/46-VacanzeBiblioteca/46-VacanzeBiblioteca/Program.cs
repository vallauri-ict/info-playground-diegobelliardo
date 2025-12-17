using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_VacanzeBiblioteca
{
    internal class Program
    {
        private static void StampaVettore(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] isbn = {1523, 4521, 7894, 2341, 8765, 3456, 9012, 6543, 1234, 5678,
                    3210, 7650, 4320, 8901, 2109, 6789, 3987, 7123, 5432, 9876 };
            int[] isbnOrdinato = {1234, 1523, 2109, 2341, 3210, 3456, 3987, 4320, 4521, 5432,
                    5678, 6543, 6789, 7123, 7650, 7894, 8765, 8901, 9012, 9876};

            int isbnDaCercare;

            Console.WriteLine("=====  GESTIONE BIBLIOTECA DIGITALE  =====\n");
            Console.Write("Libri disponibili (ISBN): ");
            StampaVettore(isbn);
            Console.WriteLine();
            Console.Write("Libri disponibili (ISBN Ordinato): ");
            StampaVettore(isbnOrdinato);
            Console.WriteLine();

            //Ciclo?
            Console.Write("Inserisci l'ISBN del libro da cercare (0 per uscire): ");
            isbnDaCercare = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--- RISULTATI RICERCA ---\n");
            Console.WriteLine("1) RICERCA SEQUENZIALE:");

            Console.WriteLine($"✓ Libro trovato alla posizione");

        }
    }
}
