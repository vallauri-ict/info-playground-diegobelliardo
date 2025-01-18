using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_RicorsioneFattoriale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,ris;

            Console.WriteLine("CALCOLO DEL FATOTRIALE\n\n");
            Console.Write("Inserisci il numero: ");
            n=Convert.ToInt32(Console.ReadLine());

            ris = Fattoriale(n);
            Console.WriteLine("\n\nRISULTATO: " + ris);

            Console.ReadKey();
        }

        private static int Fattoriale(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fattoriale(n-1);
            }
        }
    }
}
