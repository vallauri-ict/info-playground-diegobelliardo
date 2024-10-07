using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_14p84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10,x=0,y=0;
            int[] v = new int[n];
            int[] pari = new int[n];
            int[] dispari = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                v[i] = r.Next(1, 100);
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                {
                    pari[x++] = v[i];
                }
                else
                {
                    dispari[y++] = v[i];
                }
            }
            Console.WriteLine("Elementi del vettore:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine("\nElementi del vettore Dispari:");
            for (int i = 0;i < y; i++)
            {
                Console.Write(dispari[i] + " ");
            }
            Console.WriteLine("\nElementi del vettore Pari:");
            for (int i = 0; i < x; i++)
            {
                Console.Write(pari[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
