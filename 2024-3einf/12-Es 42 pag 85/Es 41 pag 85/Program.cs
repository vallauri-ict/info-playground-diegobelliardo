using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_41_pag_85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = InserisciValore("Inserire le dimensioni della matrice (n>0): ", 2), i = 0,cont = 1, j = 0, valore = 0;
            int[,] mat = new int[r, r];
            while (cont <= r / 2)
            {
                j = cont-1;
                do
                {
                    valore++;
                    mat[i, j] = valore;
                    j++;
                } while (j < r - cont);
                while (i < r - cont)
                {
                    valore++;
                    mat[i, j] = valore;
                    i++;
                }
                while (j >= cont)
                {
                    valore++;
                    mat[i, j] = valore;
                    j--;
                }
                while (i >= cont)
                {
                    valore++;
                    mat[i, j] = valore;
                    i--;
                }
                cont++;
                i++;
            }
            if(r%2!=0)
                mat[r/2,r/2] = ++valore;
            StampaMatrice(mat);
            Console.ReadKey();
        }

        private static void StampaMatrice(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        private static int InserisciValore(string mess = "Inserire un valore:", int min = 0, int max = int.MaxValue)
        {
            int n;
            do
            {
                Console.WriteLine(mess);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max);
            return n;
        }
    }
}
