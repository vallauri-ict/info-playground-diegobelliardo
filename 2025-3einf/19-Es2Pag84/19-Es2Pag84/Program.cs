using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Es2Pag84
{
    internal class Program
    {
        static Random rnd = new Random();

        /// <summary>
        /// Legge un numero da tastiera e lo restituisce, se valido.
        /// </summary>
        /// <param name="messaggio">Messaggio visualizzato</param>
        /// <param name="soloPositivi">[Opsionale] Se true accetta solo positivi</param>
        /// <returns>Numero inserito da tastiera</returns>
        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            bool isCorrect = false;
            int numero;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il prezzo deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return numero;
        }
        private static void CaricaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                vettore[i] = rnd.Next(100);
            }
        }
        private static void StampaVettore(int[] vettoreSorgente)
        {
            for (int i = 0; i < vettoreSorgente.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vettoreSorgente[i]}");
            }
        }
        private static void CopiaInvertiVettore(int[] vettoreSorgente, int[] vettoreDestinazione)
        {
            int j = vettoreSorgente.Length - 1;
            for (int i = 0; i < vettoreSorgente.Length; i++)
            {
                vettoreDestinazione[j] = vettoreSorgente[i];
                j--;
            }
        }
        static void Main(string[] args)
        {
            int lunghezzaVet = LeggiNumero("Inserisci la dimensione del Vettore: ");

            int[] vettoreSorgente = new int[lunghezzaVet];
            int[] vettoreDestinazione = new int[lunghezzaVet];

            CaricaVettore(vettoreSorgente);
            Console.WriteLine("Vettore Sorgente prima della copia");
            StampaVettore(vettoreSorgente);

            CopiaInvertiVettore(vettoreSorgente, vettoreDestinazione);

            Console.WriteLine("Vettore Destinazione dopa la copia");
            StampaVettore(vettoreDestinazione);

            Console.ReadKey();
        }

    }
}
