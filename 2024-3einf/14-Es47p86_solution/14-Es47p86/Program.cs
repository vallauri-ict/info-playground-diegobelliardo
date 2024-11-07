using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Es47p86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1,mat2;
            int r;

            Console.Write("Dimensione delle matrici: ");
            r=int.Parse(Console.ReadLine());

            mat1 = new int[r, r];
            mat2 = new int[r, r];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Clear();
                    stampaMat(mat1);
                    Console.WriteLine();
                    stampaMat(mat2);
                    Console.WriteLine();
                    Console.Write($"Insersici l'elemento [{i},{j}]: ");
                    mat1[i, j] = int.Parse(Console.ReadLine());
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            if (diagonaliUguali(mat1,mat2))
            {
                Console.WriteLine("Le diagonali delle matrici sono uguali");
            }
            else
            {
                Console.WriteLine("Le diagonali delle matrici NON sono uguali");
            }
            Console.ReadKey();
        }

        private static bool diagonaliUguali(int[,] mat1, int[,] mat2)
        {
            bool ugualiDiag = true;
            int i = 0, j ;

            while (i < mat1.GetLength(0) && ugualiDiag)
            {
                j = 0;
                while (j < mat1.GetLength(0) && ugualiDiag)
                {
                    if (i==j && mat1[i, j] != mat2[i,j])
                    {
                        ugualiDiag = false;
                    }
                    if (j==(mat1.GetLength(0) - i -1) && mat1[i, j] != mat2[i, j])
                    {
                        ugualiDiag = false;
                    }
                    j++;
                }
                i++;
            }

            return ugualiDiag;
        }

        private static void stampaMat(int[,] mat1)
        {
            for (int i = 0;i < mat1.GetLength(0); i++)
            {
                for(int j = 0;j < mat1.GetLength(1); j++)
                {
                    Console.Write(mat1[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }
    }
}
