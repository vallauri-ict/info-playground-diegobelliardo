using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Es8Pag84
{
    internal class Program
    {
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
                Console.Write(messaggio);
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
            Random casuale = new Random();
            for (int i = 0; i < vettore.Length; i++)
            {
                vettore[i] = casuale.Next(100);
            }
        }
        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
            }
        }
        /// <summary>
        /// Esegue: la somma dei numeri in posizione pari e la somma dei numeri in posizione dispari
        /// </summary>
        /// <param name="vettore"></param>
        /// <param name="contaPari"></param>
        /// <param name="contaDispari"></param>
        private static void SommaPariDispari(int[] vettore, ref int contaPari, ref int contaDispari)
        {
            for(int i = 0;i < vettore.Length; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    contaPari += vettore[i];
                }
                else contaDispari += vettore[i];
            }
        }
        static void Main(string[] args)
        {
            int n = LeggiNumero("Dimensione del vettore: ");
            int[] vet=new int[n];
            int contaPari=0, contaDispari=0;

            CaricaVettore(vet);
            StampaVettore(vet);

            SommaPariDispari(vet,ref contaPari,ref contaDispari);
            Console.WriteLine($"La somma degli elementi con indice pari è {contaPari}\nLa somma degli elementi con indice dispari è {contaDispari}");

            Console.ReadKey();
        }

    }
}
