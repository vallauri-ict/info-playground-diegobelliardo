using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Es35p85
{
    internal class Program
    {
        static int[,] mat=new int[3,3];
        static void Main(string[] args)
        {
            int i,j;
            caricaMat(mat);
            stampaMat(mat);

            i = leggiNumero("Inserisci la riga: ");
            j = leggiNumero("Inserisci la colonna: ");

            if (sommaNumeri(mat,i,"r") == sommaNumeri(mat, j,"c"))
            {
                Console.WriteLine("La somma dei numeri sulla riga inserita è uguale alla somma dei numeri sulla colonna!");
            }
            else Console.WriteLine("La somma dei numeri su riga e colonna sono diversi!");

            Console.ReadKey();
        }

        private static int sommaNumeri(int[,] mat, int n, string direzione)
        {
            int somma = 0;

            if (direzione.ToUpper() == "R")
            {
                for (int i = 0; i < mat.GetLength(1); i++)
                {
                    somma += mat[n,i];
                }
            }
            else
            {
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    somma += mat[i, n];
                }
            }
            return somma;
        }

        private static void stampaMat(int[,] mat)
        {
            Console.Clear();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i,j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        private static void caricaMat(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = leggiNumero($"Inserisci l'elemento [{i},{j}]: ");
                }
            }
        }

        private static int leggiNumero(string v)
        {
            int n;
            string s="";
            do
            {
//                Console.Clear();
                Console.Write(v);
                s=Console.ReadLine();
            } while (!(int.TryParse(s, out n)));
            return n;
        }
    }
}
