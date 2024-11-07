using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_Es44p85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r, c;
            int[,] mat;

            Console.Write("Inserisci il numero di righe: ");
            r=int.Parse(Console.ReadLine());
            Console.Write("Inserisci il numero di colonne: ");
            c = int.Parse(Console.ReadLine());
            mat=new int[r,c];

            inserisciOrdinato(mat);
            stampaMat(mat);
            Console.WriteLine();
            if (matOrdinata(mat))
            {
                Console.WriteLine("La matrice è ordinata!!");
            }
            else
            {
                Console.WriteLine("La matrice NON è ordinata!!");
            }
            Console.ReadKey();
        }

        private static void stampaMat(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i,j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }

        private static bool matOrdinata(int[,] mat)
        {
            bool ordinata = true;
            int aus=int.MinValue;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(aus== int.MinValue)
                    {
                        aus = mat[i,j];
                    }
                    else
                    {
                        if (!(mat[i,j] >= aus))
                        {
                            ordinata = false;
                        }
                    }
                }
            }

            return ordinata;
        }

        private static void inserisciOrdinato(int[,] mat)
        {
            int val = 1;

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = val++;
                }
            }
        }
    }
}
