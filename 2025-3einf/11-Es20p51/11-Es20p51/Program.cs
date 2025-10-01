using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Es20p51
{
    internal class Program
    {
        static int LeggiNumero(string messaggio)
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
                    Console.WriteLine("Devi inserire un numero Intero!!!");
                }
            } while (!isCorrect);

            return numero;
        }

        static void Main(string[] args)
        {
            int nGiorniPrestito;

            Console.OutputEncoding = Encoding.UTF8; // Forza l'encoding della console a UTF8

            nGiorniPrestito = LeggiNumero("Inserisci il numero di giorni trascorsi dal prestito: ");
            if (nGiorniPrestito <= 15)
            {
                Console.WriteLine("Non sei, al momento, in multa");
            }
            else
            {
                int nGiorniMulta = nGiorniPrestito - 15;
                Console.WriteLine($"Devi pagare una multa di {nGiorniMulta * 0.2}€");
            }

            Console.ReadKey();
        }
    }
}
