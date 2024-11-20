using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Es59p86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int r, c;

            Console.Write("Inserisci dimensione matrice rxc\nr: ");
            r = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = int.Parse(Console.ReadLine());
            mat = new int[r, c];
            
            inserisciDati(mat);

            ordinaMatrice(mat);

            stampaMat(mat);

            Console.ReadKey();
        }

        private static void ordinaMatrice(int[,] mat)
        {
            int min, posMinI, posMinJ;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    min=trovaMin(mat, i, j, out posMinI, out posMinJ);
                    mat[posMinI,posMinJ] = mat[i,j];
                    mat[i,j] = min;
                    Console.WriteLine();
                    stampaMat(mat);
                }
            }
        }

        private static int trovaMin(int[,] mat, int i, int j, 
                        out int posMinI, out int posMinJ)
        {
            int minVal=mat[i,j];

            posMinI = i;
            posMinJ = j;

            for (int i1=i; i1<mat.GetLength(0); i1++)
            {
                for (int j1 = j; j1 < mat.GetLength(1); j1++)
                {
                    if (mat[i1,j1]<minVal)
                    {
                        minVal = mat[i1,j1];
                        posMinI = i1;
                        posMinJ = j1;
                    }
                    j = 0;
                }
            }

            return minVal;
        }

        private static void inserisciDati(int[,] mat)
        {
            int r = mat.GetLength(0);
            int c = mat.GetLength(1);
            Random rnd = new Random();

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    mat[i,j]=rnd.Next(100);
                }
            }
            Console.Clear();
            stampaMat(mat);
        }

        private static void stampaMat(int[,] mat1)
        {
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write(mat1[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
        }
    }
}
