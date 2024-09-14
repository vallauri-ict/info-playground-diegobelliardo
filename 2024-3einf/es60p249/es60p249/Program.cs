using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es60p249
{
    class Program
    {
        /* Ricevuto in ingresso un numero intero positivo n, visualizza un triangolo formato da n righe.
        Per esempio, se n=4 visualizzi:
        1
        2 3
        4 5 6
        7 8 9 10*/

        // linea singola da commentare

        static void Main(string[] args)
        {
            int n=1, i, j, cont = 1;

            do
            {
                Console.Write("inserisci un numero intero positivo: ");
                n=Convert.ToInt32( Console.ReadLine());
            } while (n <= 0);

            for (i = 0; i <= n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(cont++ + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
