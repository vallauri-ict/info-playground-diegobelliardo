using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Es48p86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            int[,] mat1, mat2;
            int somma1=0, somma2=0;

            Console.Write("Inserisci dimensione matrice quadrata: ");
            r=int.Parse(Console.ReadLine());
            mat1=new int[r,r];
            mat2 = new int[r, r];

            inserisciDati(mat1,mat2);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (i == (r - j - 1))
                    {
                        if (mat1[i,j] != mat2[i,j])
                        {
                            somma1 += mat1[i, j];
                            somma2 += mat2[i, j];
                        }
                    }
                }
            }

            if (somma1==somma2)
            {
                Console.WriteLine("La media delle diagonali secondarie è uguale!");
            }
            else Console.WriteLine("La media delle diagonali secondarie NON è uguale!");

            Console.ReadKey();
        }

        private static void stampaMat(int[,] mat1)
        {
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write(mat1[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }

        private static void inserisciDati(int[,] mat1, int[,] mat2)
        {
            int r=mat1.GetLength(0);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Clear();
                    stampaMat(mat1);
                    Console.WriteLine();
                    stampaMat(mat2);
                    Console.WriteLine();
                    Console.Write($"Insersici l'elemento mat1[{i},{j}]: ");
                    mat1[i, j] = int.Parse(Console.ReadLine());
                    Console.Write($"Insersici l'elemento mat2[{i},{j}]: ");
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        /*
        4x4
        0 0 0 0
        0 0 0 0
        0 0 0 0
        0 0 0 0

        Diag. secondaria: 3,0 - 2,1 - 1,2 - 0,3

        i=r-j-1

        */

    }
}
