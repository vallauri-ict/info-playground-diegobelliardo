using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_VetMaxMin
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[] vet;
            int n,min,max;
            Random rnd = new Random();

            Console.Write("Lunghezza vettore: ");
            n = Convert.ToInt32(Console.ReadLine());
            vet= new int[n];
            for (int i = 0; i < n; i++)
            {
                vet[i] = rnd.Next(1,100);
            }
            //max = int.MinValue;
            //min= int.MaxValue;
            max = min = vet[0];

            for (int i = 1; i < n; i++)
            {
                if (vet[i] > max)
                {
                    max = vet[i];
                }
                if (vet[i] < min)
                {
                    min = vet[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i]+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Il valore minimo è: " + min);
            Console.WriteLine("Il valore massimo è: " + max);

            Console.ReadKey();
        }
    }
}
