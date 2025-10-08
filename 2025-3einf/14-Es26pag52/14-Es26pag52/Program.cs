using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Es26pag52
{
    internal class Program
    {
        static int fattoriale = 1;
        static int LeggiNumero(string messaggio,bool soloPositivi=true)
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
        private static void CalcolaFattoriale(int n)
        {
            while (n > 1)
            {
                fattoriale = fattoriale * n;
                n--;
            }
        }


        static void Main(string[] args)
        {
            int n;

            n = LeggiNumero("Inserisci il numero di cui vuoi il fattoriale: ");
            CalcolaFattoriale(n);
            Console.WriteLine($"Il fattoriale di {n} vale {fattoriale}");

            Console.ReadKey();
        }

    }
}
