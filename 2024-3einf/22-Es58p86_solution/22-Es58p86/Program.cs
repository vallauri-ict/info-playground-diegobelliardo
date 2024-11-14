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
            int r, centro, offset;

            Console.Write("Inserisci dimensione matrice rxr: ");
            r = int.Parse(Console.ReadLine());

            mat = new int[r, r];
            //centro = (int)Math.Ceiling((decimal)(r / 2.0)); Non necessario
            centro = r / 2;
            /*
             * 0 0 0 1 0 0 0
             * 0 0 1   1 0 0
             * 0 1   2   1 0
             * 1   3   3   1
             *   4   6   4
             */

            offset = 0;
            for (int i = 0; i < mat.GetLength(0)/2+1; i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (centro-offset==j || centro+offset==j)
                    {
                        mat[i, j] = 1;
                    }
                    if (i > 1 && j>1 && j< mat.GetLength(1)-1 && 
                        mat[i - 1, j - 1] != 0 && mat[i - 1, j + 1] != 0)
                    {
                        mat[i, j] = mat[i - 1, j - 1] + mat[i -1, j + 1];
                    }
                }
                offset++;
            }

            stampaMat(mat);

            Console.ReadKey();

        }

        private static void stampaMat(int[,] mat1)
        {
            for (int i = 0; i < mat1.GetLength(0)/2+1; i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    if (mat1[i, j] == 0) Console.Write(" ".PadLeft(5));
                    else Console.Write(mat1[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
        }
    }
}
