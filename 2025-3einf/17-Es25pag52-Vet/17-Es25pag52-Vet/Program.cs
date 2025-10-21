using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Es25pag52_Vet
{
    internal class Program
    {
        static double media = 0;
        static int nNumeri;

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
        static void Main(string[] args)
        {

            nNumeri = LeggiNumero("Di quanti numeri vuoi fare la media? ");


        }
    }
}
