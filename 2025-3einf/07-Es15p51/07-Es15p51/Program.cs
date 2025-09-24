using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Es15p51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prezzo;
            bool isCorrect;

            Console.OutputEncoding = Encoding.UTF8; // Forza l'encoding della console a UTF8

            do
            {
                Console.Write("Inserisci il prezzo: ");
                if (double.TryParse(Console.ReadLine(), out prezzo))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && prezzo <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il prezzo deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            if (prezzo < 100)
                prezzo = prezzo * 0.95;
            else if (prezzo < 300 && prezzo >= 100) prezzo = prezzo * 0.9;
            else prezzo = prezzo * 0.8;

            Console.WriteLine("Il costo finale è di: " + prezzo + "€");
            Console.ReadKey();
        }
    }
}
