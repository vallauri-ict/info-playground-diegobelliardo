using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es38p85
{
    internal class Program
    {
        private static int[,] mat = new int[5, 5];
        static void Main(string[] args)
        {
            bool unitaria=true;

            caricaMat(mat);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j && mat[i, j] != 1)
                    {
                        unitaria = false;
                    }
                    else
                    {
                        if (i != j && mat[i, j] != 0)
                        {
                            unitaria = false;
                        }
                    }
                }
            }

            if (unitaria)
            {
                Console.WriteLine("La matrice è una matrice unitaria");
            }
            else Console.WriteLine("La matrice NON è una matrice unitaria");

            Console.ReadKey();
        }

        private static void caricaMat(int[,] mat)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    stampaMat(mat);
                    Console.Write("\n\n\n");
                    Console.Write($"Inserisci l'elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void stampaMat(int[,] mat)
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }
}
