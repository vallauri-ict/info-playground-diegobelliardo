using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Es53p86
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
             * 0 0 0 0
             * 0 0 0 1
             * 0 0 2 3
             * 0 4 5 6
             * 
             * 1,3 - 2,2 - 2,3 - 3,1 - 3,2 - 3,3
             * 
             * 0,0 - 0,1 - 0,2 - 0,3 - 1,0 - 1,1 - 1,2
             * 2,0 - 2,1 - 3,0
             */

            int somma = sommaVal1(mat);
            Console.WriteLine("1) La somma degli elementi al di sotto della diagonale è: " + somma);

            somma = sommaVal2(mat);
            Console.WriteLine("2) La somma degli elementi al di sotto della diagonale è: " + somma);

            Console.ReadKey();
        }

        private static int sommaVal2(int[,] mat)
        {
            int somma = 0, j;

            for (int i = 1; i < mat.GetLength(0); i++)
            {
                //for(int j = 0;j< mat.GetLength(1); j++)
                //{
                //    if (j < i)
                //    {
                //        somma += mat[i, j];
                //    }
                //}

                j = mat.GetLength(1)-1;
                while ((i+j) >= mat.GetLength(1))
                {
                    somma += mat[i, j];
                    j--;
                }
            }

            return somma;
        }

        private static int sommaVal1(int[,] mat)
        {
            int i = 1, j, posPrimoElm = mat.GetLength(1)-1, somma = 0;

            while (i < mat.GetLength(0))
            {
                j = mat.GetLength(1)-1;
                while (j >= posPrimoElm)
                {
                    somma += mat[i, j];
                    j--;
                }
                posPrimoElm--;
                i++;
            }
            return somma;
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
