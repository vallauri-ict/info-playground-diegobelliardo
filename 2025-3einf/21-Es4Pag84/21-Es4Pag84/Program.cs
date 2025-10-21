using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _21_Es4Pag84
{
    internal class Program
    {
        static Random rnd = new Random();
        static int maxGlobal, minGlobal;

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

        /// <summary>
        /// Riempe un vettore di interi con valori casuali compresi tra 0 e 99.
        /// </summary>
        /// <param name="vettore1">Array di interi da caricare.</param>
        private static void CaricaVettore(int[] vettore1)
        {
            for (int i = 0; i < vettore1.Length; i++)
            {
                vettore1[i] = rnd.Next(100);
            }
        }

        /// <summary>
        /// Stampa a video tutti gli elementi di un vettore con il loro indice.
        /// </summary>
        /// <param name="vettoreSorgente">Array di interi da stampare.</param>
        private static void StampaVettore(int[] vettoreSorgente)
        {
            for (int i = 0; i < vettoreSorgente.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vettoreSorgente[i]}");
            }
        }
        private static void CercaMaxMin(int[] vettore, ref int max, ref int min)
        {
            max = int.MinValue;
            min = int.MaxValue;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (max < vettore[i])
                {
                    max = vettore[i];
                }
                if (min > vettore[i])
                {
                    min = vettore[i];
                }
            }
        }

        private static void CercaMaxMinGlobal(int[] vettore)
        {
            maxGlobal = int.MinValue;
            minGlobal = int.MaxValue;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (maxGlobal < vettore[i])
                {
                    maxGlobal = vettore[i];
                }
                if (minGlobal > vettore[i])
                {
                    minGlobal = vettore[i];
                }
            }
        }

        static void Main(string[] args)
        {
            int lunghezzaVet,max,min;

            lunghezzaVet = LeggiNumero("Inserisci le dimensioni del vettore: ");
            int[] vet = new int[lunghezzaVet];

            CaricaVettore(vet);

            max = min = 0;
            CercaMaxMin(vet,ref max, ref min);
            CercaMaxMinGlobal(vet);

            Console.WriteLine($"Passaggio per riferimento:\nMax: {max}\nMin: {min}");
            Console.WriteLine($"Variabili globali:\nMax: {maxGlobal}\nMin: {minGlobal}");

            Console.ReadKey();
        }

    }
}
