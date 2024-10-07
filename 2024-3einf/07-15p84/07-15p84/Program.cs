using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_15p84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10,x=0,y=n-1;
            int[] a = new int[n];
            int[] b = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 100);
            }
            for (int i = 0;i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[x++] = a[i];
                }
                else
                {
                    b[y--] = a[i];
                }
            }
            Console.WriteLine("Elementi di a:");
            for(int i = 0;i<n; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\nElementi di b:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
