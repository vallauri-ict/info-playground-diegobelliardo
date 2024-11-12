using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Es54p86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int r;

            Console.Write("Inserisci dimensione matrice rxr: ");
            r = int.Parse(Console.ReadLine());

            mat = new int[r, r];
            inserisciDati(mat);
            Console.Clear();
            stampaMat(mat);
            Console.WriteLine();

            /*
             * 1 2 3 4
             * 1 5 6 7
             * 1 1 8 9
             * 1 1 1 9
             * 
             * 1,0 - 2,0 - 2,1 - 3,0 - 3,1 - 3,2
             */

            if (ElemUguali(mat))
            {
                Console.WriteLine("1) Gli elementi al di sotto della diagonale sono uguali");
            }
            else Console.WriteLine("1) Gli elementi al di sotto della diagonale NON sono uguali");
            if (ElemUguali2(mat))
            {
                Console.WriteLine("2) Gli elementi al di sotto della diagonale sono uguali");
            }
            else Console.WriteLine("2) Gli elementi al di sotto della diagonale NON sono uguali");
            
            Console.ReadKey();
        }

        private static bool ElemUguali2(int[,] mat)
        {
            int j, val = mat[1,0];
            bool uguali=true;

            for (int i = 1; i < mat.GetLength(0); i++)
            {
                //for(int j = 0;j< mat.GetLength(1); j++)
                //{
                //    if (j < i)
                //    {
                //        somma += mat[i, j];
                //    }
                //}

                j = 0;
                while (j < i && uguali)
                {
                    if (mat[i,j] != val) uguali = false;
                    j++;
                }
            }

            return uguali;
        }

        private static bool ElemUguali(int[,] mat)
        {
            int i = 1, j, nElem = 1, val = mat[1,0];
            bool uguali = true;

            while (i < mat.GetLength(0))
            {
                j = 0;
                while (j < nElem && uguali)
                {
                    if (mat[i,j] != val) uguali = false;
                    j++;
                }
                nElem++;
                i++;
            }
            return uguali;
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
        private static void inserisciDati(int[,] mat)
        {
            int r = mat.GetLength(0);
            int c = mat.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Clear();
                    stampaMat(mat);
                    Console.WriteLine();

                    Console.Write($"Insersici l'elemento mat[{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
