using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Es9Pag84
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
        /// <summary>
        /// Caricamento casuale degli elementi di un vettore
        /// </summary>
        /// <param name="vettore"></param>
        /// <param name="tipologia">n: >= 0 
        ///                         p: > 0
        ///                         z: interi </param>
        private static void CaricaVettore(int[] vettore, char tipologia='n')
        {
            Random casuale = new Random();
            for (int i = 0; i < vettore.Length; i++)
            {
                switch (tipologia)
                {
                    case 'n':
                        vettore[i] = casuale.Next(100);
                        break;
                    case 'p':
                        vettore[i] = casuale.Next(99)+1;
                        break;
                    case 'z':
                        vettore[i] = casuale.Next(199) - 99;
                        break;
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
        private static void ContaPositiviNegativi(int[] vettore, ref int contaPositivi, ref int contaNegativi)
        {
            for(int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] > 0)
                    contaPositivi++;
                else if (vettore[i] < 0) contaNegativi++;
            }
        }
        static void Main(string[] args)
        {
            int n = LeggiNumero("Dimensione del vettore: ");
            int[] vet=new int[n];
            int contaPositivi = 0, contaNegativi=0;

            CaricaVettore(vet, 'z');
            StampaVettore(vet);

            ContaPositiviNegativi(vet, ref contaPositivi, ref contaNegativi);

            Console.WriteLine($"Nel vettore ci sono {contaPositivi} numeri positivi e {contaNegativi} numeri negativi");

            Console.ReadKey();
        }

    }
}
