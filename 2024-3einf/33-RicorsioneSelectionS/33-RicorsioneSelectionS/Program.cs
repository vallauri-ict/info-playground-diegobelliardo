using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_RicorsioneSelectionS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int[] vr = new int[10];
            Random r = new Random();

            Console.WriteLine("SELECTION SORT RICORSIVO\n");
            CaricaVet(v, r);
            CopiaVet(v, vr);
            StampaVet(v);
            SelectionSort(v);
            SelectionSortRicorsivo(v);

        }

        private static void SelectionSortRicorsivo(int[] v)
        {
            throw new NotImplementedException();
        }

        private static void CopiaVet(int[] v, int[] vr)
        {
            throw new NotImplementedException();
        }

        private static void SelectionSort(int[] v)
        {
            
        }

        private static void StampaVet(int[] v)
        {
            for (int i = 0; i< v.Length; i++)
            {
                Console.Write(v[i].ToString().PadLeft(3));
            }
        }

        private static void CaricaVet(int[] v, Random r)
        {
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = r.Next(1, 100);
            }
        }
    }
}
