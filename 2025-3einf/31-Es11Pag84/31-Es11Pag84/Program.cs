using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Es11Pag84
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
        private static void CaricaVettore(int[] vettore, char tipologia = 'n', int min=0, int max=100)
        {
            
            for (int i = 0; i < vettore.Length; i++)
            {
                switch (tipologia)
                {
                    case 'n':
                        vettore[i] = casuale.Next(min,max);
                        break;
                    case 'p':
                        vettore[i] = casuale.Next(max-1) + 1;
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
        private static int CopiaElementiUguali(int[] vetA, int[] vetB, int[] vetC)
        {
            int j = 0;
            for (int i = 0; i < vetA.Length; i++)
            {
                if (vetA[i] == vetB[i])
                {
                    vetC[j] = vetA[i];
                    j++;
                }
            }
            return j;
        }
        static void Main(string[] args)
        {
            int n = LeggiNumero("Dimensione vettore: ");
            int[] vetA= new int[n];
            int[] vetB = new int[n];
            int[] vetC = new int[n];
            int dimensioneC;

            CaricaVettore(vetA,'n',0,8);
            CaricaVettore(vetB,'n',0,8);

            dimensioneC = CopiaElementiUguali(vetA, vetB, vetC);

            Array.Resize(ref vetC, dimensioneC);

            Console.WriteLine("\nVettore A:");
            StampaVettore(vetA);
            Console.WriteLine("\nVettore B:");
            StampaVettore(vetB);
            Console.WriteLine("\nVettore C:");
            StampaVettore(vetC);

            Console.ReadKey();
        }

    }
}
