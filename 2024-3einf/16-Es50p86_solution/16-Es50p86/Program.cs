using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Es50p86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int r, c;
            int[] colonna;

            Console.Write("Inserisci dimensione matrice rxc\nr: ");
            r = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = int.Parse(Console.ReadLine());
            mat = new int[r, c];
            colonna = new int[r];

            inserisciDati(mat);
            Console.Clear();
            stampaMat(mat);
            Console.WriteLine();

            for (int i = 0; i < r; i++)
            {
                colonna[i] = sommaRiga(mat,i);
            }

            stampaVet(colonna);
            Console.ReadKey();
        }

        private static void stampaVet(int[] colonna)
        {
            Console.WriteLine("Vettore somma delle righe\n");
            for (int i = 0; i < colonna.Length; i++)
            {
                Console.WriteLine(colonna[i]);
            }
        }

        private static int sommaRiga(int[,] mat, int i)
        {
            int somma = 0;

            for(int j = 0; j < mat.GetLength(1); j++)
            {
                somma += mat[i,j];
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
