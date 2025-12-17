using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Correzione_verifica02
{
    internal class Program
    {
        static Random rnd = new Random();
        private static int LeggiNumero(string messaggio)
        {
            string n;
            int num = 0;
            bool ok;
            do
            {
                Console.Write(messaggio);
                n = Console.ReadLine();

                ok = int.TryParse(n, out num);

                if (num <= 3) ok = false;    // Il vettore deve avere almeno 3 elementi

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
                int val= rnd.Next(a.Length * 2); // n*2 escluso
                while (CercaVal(a, val,i))
                {
                    val = rnd.Next(a.Length * 2); // n*2 escluso
                }
                a[i] = val;
            }
        }

        private static bool CercaVal(int[] a, int val, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i]==val)
                {
                    return true;
                }
            }
            return false;
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
            int n = LeggiNumero("Inserisci la dimensione del vettore: ");
            int[] vet = new int[n];

            CaricaVet(vet);

            StampaVettore(vet);


        }
    }
}
