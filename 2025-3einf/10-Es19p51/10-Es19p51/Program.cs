using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Es19p51
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
            int nRagazzi, nRagazze;
            double spesaTotale;

            nRagazzi = LeggiNumero("Inserisci il numero dei ragazzi: ");
            nRagazze = LeggiNumero("Inserisci il numero delle ragazze: ");

            spesaTotale = nRagazzi * 12 + nRagazze * 12 * 0.7;
            Console.WriteLine($"La spesa totale è {spesaTotale}");
            
            Console.ReadKey();
        }
    }
}
