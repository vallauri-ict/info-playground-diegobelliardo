using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Matrice01
{
    internal class Program
    {
        int[] v = new int[10];    // Dichiarazione vettore di 10 interi
        int[,] m = new int[5,5];  // Matrice di 5x5 interi
        static int[,] mat;

        static void Main(string[] args)
        {
            int r,c;
            do
            {
                Console.Write("Inserisci il numero di righe della matrice: ");
                r=int.Parse(Console.ReadLine());
                Console.Write("Inserisci il numero di colonne della matrice: ");
                c=int.Parse(Console.ReadLine());
                //            } while (!(r>0 && c>0));  // r<=0 || c<=0
            } while (r <= 0 || c <= 0);
            mat = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Inserisci l'elemento [{i},{j}]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }

            }
            Console.ReadKey();
        }
    }
}
