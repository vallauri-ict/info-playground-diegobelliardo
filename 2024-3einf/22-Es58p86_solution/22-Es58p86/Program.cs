using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Es58p86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int r, centro,cont;

            Console.Write("Inserisci dimensione matrice rxr: ");
            r = int.Parse(Console.ReadLine());

            mat = new int[r, r];
            centro = (int)Math.Ceiling((decimal)(r / 2.0));

            //Math.Round()

            /*
             * 0 0 0 1 0 0 0
             * 0 0 1   1 0 0
             * 0 1   2   1 0
             * 1   3   3   1
             *   4   6   4
             */

            Console.ReadKey();

        }
    }
}
