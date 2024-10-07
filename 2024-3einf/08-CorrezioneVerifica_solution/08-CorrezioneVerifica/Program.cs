using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CorrezioneVerifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max=int.MinValue, min=int.MaxValue, somma=0;
            double media=0;
            int[] v=new int[10];
            Random rand = new Random();

            for(int i=0; i<10; i++)
            {
                v[i] = rand.Next(1,10);
            }
            Console.WriteLine("Elementi del vettore:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                }
                if (v[i] < min)
                {
                    min = v[i];
                }
                media += v[i];
                if (i % 3 == 0 && i>0)
                {
                    somma += v[i];
                }
            }
            Console.WriteLine("Minimo: "+min);
            Console.WriteLine("Massimo: " + max);
            Console.WriteLine("Media: " + media/10);
            Console.WriteLine("Somma multipli di 3: " + somma);

            Console.ReadKey();
        }
    }
}
