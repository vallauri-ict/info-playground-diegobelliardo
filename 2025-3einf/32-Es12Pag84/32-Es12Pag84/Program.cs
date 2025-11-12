using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Es12Pag84
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
        /// Caricamento casuale degli elementi di un vettore
        /// </summary>
        /// <param name="vettore"></param>
        /// <param name="tipologia">n: min <=(numero generato) < max
        ///                         p: 0 < (numero generato) < max
        /// </param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        private static void CaricaVettore(int[] vettore, char tipologia = 'n', int min = 0, int max = 100)
        {

            for (int i = 0; i < vettore.Length; i++)
            {
                switch (tipologia)
                {
                    case 'n':
                        vettore[i] = casuale.Next(min, max);
                        break;
                    case 'p':
                        vettore[i] = casuale.Next(max - 1) + 1;
                        break;
                        /*  case 'z':
                              vettore[i] = casuale.Next(199) - 99;
                              break;*/
                }
            }
        }
        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
            }
        }
        private static double CalcolaMedia(int[] vettore)
        {
            int somma = 0;
            for (int i = 0; i < vettore.Length; i++)
            {
                somma += vettore[i];
            }

            return somma / vettore.Length;
        }
        static void Main(string[] args)
        {
            int n = LeggiNumero("Dimensione dei vettori: ");
            int[] a = new int[n];
            int[] b = new int[n];

            CaricaVettore(a);
            CaricaVettore(b);

            double mediaA = CalcolaMedia(a);
            double mediaB = CalcolaMedia(b);

            if (mediaA == mediaB)
            {
                Console.WriteLine($"Media di a: {mediaA}\nMedia di b: {mediaB}\n****** Le medie sono uguali ******");
            }
            else
            {
                Console.WriteLine($"Media di a: {mediaA}\nMedia di b: {mediaB}\n****** Le medie sono diverse ******");
            }

            Console.ReadKey();
        }
    }
}
