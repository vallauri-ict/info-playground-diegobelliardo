using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RandomVet
{
    /* Caricare ogni volta un vettore di elementi Random 
     * (di dimensione n) fino a quando, la somma degli 
     * elementi in posizione pari e' maggiore o uguale alla 
     * somma di quelli in posizione dispari. */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v;  // int[] v=new int[10];
            int i=0,j,n,sp=0,sd=0;
            Random rnd = new Random();

            Console.Write("Inserisci n: ");
            n= Convert.ToInt32(Console.ReadLine());

            v= new int[n];

            do
            {
                v[i] = rnd.Next(100);
                if ((i+1) % 2 == 0)
                {
                    sp = sp + v[i];
                }
                else sd= sd + v[i];
                i++;
            } while (sp < sd && i<n);

            if (sp >= sd)
            {
                Console.WriteLine("La somma degli elementi pari è maggiore a quella degli elementi dispari.");
            }
            else
                Console.WriteLine("Vettore pieno!!!");

            for (j = 0; j < i; j++)
            {
                Console.Write(v[j]+" ");
            }

            Console.ReadKey();
        }
    }
}
