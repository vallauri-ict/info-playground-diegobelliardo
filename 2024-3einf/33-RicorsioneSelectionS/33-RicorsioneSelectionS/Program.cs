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
            v.CopyTo(vr,0);
            //CopiaVet(v, vr);
            StampaVet(v);
            Console.ReadKey();

            Console.WriteLine("\n\nVettore Ordinato con metodo classico:");
            SelectionSort(v);
            StampaVet(v);

            Console.WriteLine("\n\nVettore Ordinato con metodo ricorsivo:");
            SelectionSortRicorsivo(vr,0);
            StampaVet(vr);

            Console.ReadKey();
        }

        private static void SelectionSortRicorsivo(int[] v,int startIndex)
        {
            if (startIndex == v.Length-1) { return; }

            int minIndex = startIndex;
            for (int j = startIndex + 1; j < v.Length; j++)
            {
                if (v[j] < v[minIndex])
                {
                    minIndex = j;
                }
            }

            //scambio elementi
            if (minIndex != startIndex)
            {
                int temp = v[startIndex];
                v[startIndex] = v[minIndex];
                v[minIndex] = temp;
            }

            Console.WriteLine();
            StampaVet(v);

            //Chiamata ricorsiva per il resto del vettore
            SelectionSortRicorsivo(v,startIndex+1);
        }

        private static void SelectionSort(int[] v)
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[j] < v[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //scambio elementi
                if (minIndex != i)
                {
                    int temp = v[i];
                    v[i] = v[minIndex];
                    v[minIndex] = temp;
                }

                Console.WriteLine();
                StampaVet(v);
            }
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
