using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Es56p86
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

            if (sommaUpDownUguali(mat))
            {
                Console.WriteLine("La media degli elementi al disopra della diagonale è uguale quella degli elementi al di sotto");
            }
            else Console.WriteLine("La media degli elementi al disopra della diagonale NON è uguale quella degli elementi al di sotto");

            Console.ReadKey();
        }

        private static bool sommaUpDownUguali(int[,] mat)
        {
            int sommaUp=0,sommaDown=0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        sommaDown += mat[i, j];
                    }
                    if (i > j)
                    {
                        sommaUp += mat[i, j];
                    }
                }
            }

            if(sommaUp==sommaDown) return true;
            else return false;
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
