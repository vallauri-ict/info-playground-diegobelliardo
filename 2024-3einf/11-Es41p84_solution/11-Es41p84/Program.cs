using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Es41p84
{
    internal class Program
    {
        static private int[,] mat;
        static void Main(string[] args)
        {
            int r,cont=1,i=0,j=0;

            Console.Write("Inserisci la dimensione della matrice quadrata: ");
            r=int.Parse(Console.ReadLine());
            mat = new int[r, r];

            
            while (i < r)
            {
                while (j < r)
                {
                    mat[i,j] = cont;
                    cont++;

                    j++;
                }
                
                i++;
            }



            Console.ReadKey();
        }
    }
}
