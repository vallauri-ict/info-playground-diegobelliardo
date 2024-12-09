using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Es_Ricerca_binaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, sx, dx, meta;
            int[] v = { 1, 2, 3, 4, 5};
            //          0  1  2  3  4
            sx = 0;
            dx = v.Length-1;

            Console.Write("Inserisci il numero da ricercare: ");
            x=Convert.ToInt32(Console.ReadLine());

            do
            {
                meta = (dx+sx)/2;
                if (v[meta] != x)
                {
                    if (v[meta] > x)
                    {
                        dx = meta - 1;
                    }
                    else
                    {
                        sx = meta + 1;
                    }
                }
            } while (sx<=dx && v[meta]!=x);
            if (v[meta] == x)
            {
                Console.WriteLine("L'elemento è stato trovato in posizione " + meta);
            }
            else Console.WriteLine("L'elemento non è presente nel vettore");

            Console.ReadKey();
        }
    }
}
