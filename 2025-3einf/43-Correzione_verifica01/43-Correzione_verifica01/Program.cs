using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Correzione_verifica01
{
    internal class Program
    {
        static Random rnd = new Random();
        private static int LeggiNumero(string messaggio)
        {
            string n;
            int num=0;
            bool ok;
            do
            {
                Console.Write(messaggio);
                n=Console.ReadLine();

                ok = int.TryParse(n, out num);

                if(num<=3) ok=false;    // Il vettore deve avere almeno 3 elementi

                if (!ok)
                {
                    Console.WriteLine("ERRORE: valore non valido!");
                }
            } while (!ok);
            
            return num;
        }
        private static void CaricaVet(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(10);
            }
        }
        private static void Stampa3Maggiori(int[] a)
        {
            int j=0;
            int[] ausV=new int[3];

            while (j<3)
            {
                int max=int.MinValue;
                int pos=0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i]>max)
                    {
                        max = a[i];
                        pos = i;
                    }
                }
                ausV[j++] = max;    // Prima utilizza e puoi incrementa j
                //ausV[++j] = max;   Prima incrementa e puoi utilizza j
                a[pos] = int.MinValue;
            }
            Console.Write("I 3 maggiorni sono: ");
            for (int i = ausV.Length - 1; i >= 0; i--)
            {
                Console.Write(ausV[i]+" ");
            }
        }

        private static void Stampa3MaggioriNoParimerito(int[] a)
        {
            int j = 0;
            int[] ausV = new int[3];

            while (j < 3)
            {
                int max = int.MinValue;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                ausV[j++] = max;    // Prima utilizza e puoi incrementa j
                //ausV[++j] = max;   Prima incrementa e puoi utilizza j
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == max) a[i] = int.MinValue;
                }
            }
            Console.Write("I 3 maggiorni sono: ");
            for (int i = ausV.Length - 1; i >= 0; i--)
            {
                Console.Write(ausV[i] + " ");
            }
        }
        private static void StampaVettore(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n;

            n = LeggiNumero("Inserisci la lunghezza del vettore: ");
            int[] a = new int[n];
            int[] b = new int[n];

            CaricaVet(a);
            a.CopyTo(b, 0);

            StampaVettore(a);
            Console.WriteLine();
            Stampa3Maggiori(a);

            Console.WriteLine();
            StampaVettore(b);
            Console.WriteLine();
            Stampa3MaggioriNoParimerito(b);

            Console.ReadKey();
        }

    }
}
