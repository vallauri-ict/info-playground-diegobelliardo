using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Es13Pag84
{
    internal class Program
    {
        static Random casuale = new Random();

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
        /// <summary>
        /// Caricamento manuale degli elementi di un vettore
        /// </summary>
        /// <param name="vettore"></param>
        
        private static void CaricaVettore(int[] vettore)
        {

            for (int i = 0; i < vettore.Length; i++)
            {
                Console.WriteLine($"Elemento {i}: ");
                vettore[i]=Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
            }
        }
        private static bool VettoreSpeculare(int[] a)
        {
            bool speculare = true;
            for (int i = 0; i < a.Length; i++)
            {
                if ()
                {
                    speculare=false;
                }
            }
            return speculare;
        }
        static void Main(string[] args)
        {
            int n = LeggiNumero("Dimensione vettore: ");
            int[] a=new int[n];

            Console.WriteLine("Inserisci gli elementi del vettore:");
            CaricaVettore(a);

            StampaVettore(a);

            if (VettoreSpeculare(a))
            {
                Console.WriteLine("****** Il vettore è speculare ******");
            }
            else Console.WriteLine("****** Il vettore NON è speculare ******");
        }

    }
}
