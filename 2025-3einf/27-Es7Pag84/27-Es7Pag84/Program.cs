using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Es7Pag84
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
            int numero;
            bool isCorrect;

            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadLine();
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
        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
            }
        }

        private static bool CercaNumero(int[] vettore, int numero)
        {
            bool trovato = false;
            int i = 0;

            while (i < vettore.Length && vettore[i]!=numero)
            {
                i++;
            }
            if (i<vettore.Length)
            {
                trovato = true;
            }

            return trovato;
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Dimensione vettore: ");
            int[] vet = new int[n];

            int x = LeggiNumero("Inserisci il numero da cercare: ");

            CaricaVettore(vet);
            StampaVettore(vet);

            if (CercaNumero(vet,x))
            {
                Console.WriteLine($"Il numero {x} è presente nel vettore");
            }
            else Console.WriteLine($"Il numero {x} non è stato trovato");

            Console.ReadKey();
        }
    }
}
